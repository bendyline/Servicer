/* Copyright (c) Bendyline LLC. All rights reserved. Licensed under the Apache License, Version 2.0.
    You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0. */

using BL.Data;
using System;
using System.Net;


#if NET
using Bendyline.Base;
using System.Text;

namespace Bendyline.Data
#elif SCRIPTSHARP
using System.Serialization;

namespace BL.Servicer.MSGraph
#endif
{
    public class ListItem : Item
    {
        private string id;
        private bool disconnected = false;
        private HttpRequest saveRequest;
        private String activeSaveJson = null;
        private bool additionalSaveNeeded = false;

        private ItemTypeList itemTypeList;
        private ListStore listStore;

        public event EventHandler Saving;
        public event EventHandler Saved;
        private Operation saveOperation;


        public bool IsSaving
        {
            get
            {
                return this.saveOperation != null;
            }
        }

        public bool Disconnected
        {
            get
            {
                return this.disconnected;
            }

            set
            {
                this.disconnected = value;
            }
        }

        public Operation SaveOperation
        {
            get
            {
                if (this.saveOperation == null)
                {
                    this.saveOperation = new Operation();
                }

                return this.saveOperation;
            }
        }

        public override String Id
        {
            get
            {
                if (this.id == null)
                {
                    this.id = this.GetValueAsString("Id");
                }

                return this.id;
            }
        }

        public ListStore Store
        {
            get
            {
                return (ListStore)this.Type.Store;
            }
        }

        public bool IsValid
        {
            get
            {
                Query validCriteria = ((ItemTypeList)this.Type).ValidCriteria;

                if (validCriteria == null)
                {
                    return true;
                }

                return validCriteria.ItemMatches(this);
            }
        }

        public ListItem(ItemTypeList entityType) : base(entityType)
        {
            this.itemTypeList = entityType;
            this.listStore = (ListStore)this.itemTypeList.Store;
        }

        public void SetId(String id)
        {
            this.id = id;
        }

        private String GetJson()
        {
            StringBuilder result = new StringBuilder();

            result.Append("{");

            if (this.LocalStatus == ItemLocalStatus.NewItem)
            {
                    result.Append(" \"fields\":{");
            }

            bool isFirst = true;
            foreach (Field f in this.Type.Fields)
            {
                if (f.Name != "Id" && f.Name != "CreatedDate" && f.Name != "ModifiedDate")
                {
                    String value = this.GetStringValue(f.Name);

                    if (value != null)
                    {
                        if (!isFirst)
                        {
                            result.Append(",");
                        }
                        else
                        {
                            isFirst = false;
                        }

                        if (f.Type == FieldType.BoolChoice)
                        {
                            if (value == "true")
                            {
                                result.Append("\"" + f.Name + "\":true");
                            }
                            else
                            {
                                result.Append("\"" + f.Name + "\":false");
                            }
                        }
                        else if (f.Type == FieldType.Integer || f.Type == FieldType.Geopoint || f.Type == FieldType.BigNumber)
                        {
                            result.Append("\"" + f.Name + "\":" + value);
                        }
                        else if (f.Type == FieldType.DateTime)
                        {
                            result.Append("\"" + f.Name + "\":\"" + value + "\"");
                        }
                        else
                        {
                            result.Append("\"" + f.Name + "\":\"" + JsonUtilities.Encode(value) + "\"");
                        }
                    }
                }
            }

            if (this.LocalStatus == ItemLocalStatus.NewItem)
            {
                result.Append("}");
            }

            result.Append("}");

            return result.ToString();
        }

        public void Save(AsyncCallback callback, object state)
        {
            if (this.disconnected)
            {
                throw new Exception("Cannot save a disconnected item.");
            }

            bool isNew = false;

            if (this.LocalStatus == ItemLocalStatus.Unchanged)
            {
                CallbackResult.NotifySynchronousSuccess(callback, state, this);

                if (this.Saved != null)
                {
                    this.Saved(this, EventArgs.Empty);
                }

                return;
            }

            if (this.saveOperation == null)
            {
                this.saveOperation = new Operation();
                isNew = true;
            }

            this.saveOperation.AddCallback(callback, state);

            String json = GetJson();

            if (!isNew)
            {
                if (json != this.activeSaveJson)
                {
                    this.additionalSaveNeeded = true;
                }

                return;
            }

            if (this.Saving != null)
            {
                this.Saving(this, EventArgs.Empty);
            }

            this.activeSaveJson = json;

            ((ItemTypeList)this.Type).UpdateItemInItemSets(this);

            this.SendSaveRequest();
        }

        private void SendSaveRequest()
        {
            String endpoint = ((ItemTypeList)this.Type).GraphUrl + "/items";

            HttpRequest xhr = new HttpRequest();

            xhr.SetBearerToken(this.listStore.Graph.AccessToken);

            if (this.LocalStatus == ItemLocalStatus.Update || this.LocalStatus == ItemLocalStatus.Deleted)
            {
                xhr.Verb = "PATCH";
                xhr.Url = endpoint + "/" + this.Id + "/fields";
            }
            else
            {
                xhr.Verb = "POST";
                xhr.Url = endpoint;
            }


            xhr.RequestType = HttpRequestType.ODataV4JsonWrite;

    //            xhr.SetRequestHeader("DataServiceVersion", "DataServiceVersion: 3.0;NetFx");
            xhr.OnReadyStateChange = new Action(this.HandleSaveComplete);

            this.saveRequest = xhr;

            xhr.Body = this.activeSaveJson;

            xhr.Send();
        }

        private void HandleSaveComplete()
        {
            if (this.saveRequest != null && this.saveRequest.ReadyState == ReadyState.Loaded)
            {
                ItemLocalStatus previousStatus = this.LocalStatus;

                if (this.saveRequest.Status < 400)
                {
                    String responseContent = this.saveRequest.ResponseText;

                    if (!String.IsNullOrEmpty(responseContent))
                    {
#if SCRIPTSHARP
                        object results = Json.Parse(responseContent);

                        Script.Literal(@"
                    var oc = {0};
                    var fields = {0}.fields;
                    var fieldarr = {1};

                        for (var j=0; j<fieldarr.length; j++)
                        {{
                            var fi = fieldarr[j];
                            var fiName = fi.get_name();

                            var val = oc[fi.get_name()];

                            if (val != null)
                            {{
                                this.localSetValue(fiName, val);
                            }}
                            else if (fields != null)
                            {{
                                var valA = fields[fi.get_name()];

                                if (valA != null)
                                {{
                                    this.localSetValue(fiName, valA);
                                }}
                            }}
                        }}

                if ({2}==0 && oc[""id""] !=null)
                {{
                    this.setId(oc[""id""]);
                }}    
", results, this.Type.Fields, previousStatus);
#else
                        throw new NotImplementedException();
#endif

                    }
                }

                this.saveRequest = null;

                if (this.additionalSaveNeeded)
                {
                    this.additionalSaveNeeded = false;
                    this.activeSaveJson = this.GetJson();
                    this.SendSaveRequest();
                }
                else
                {
                    this.SetLocalStatus(ItemLocalStatus.Unchanged);

                    if (this.Saved != null)
                    {
                        this.Saved(this, EventArgs.Empty);
                    }

                    Operation o = this.saveOperation;

                    this.saveOperation = null;

                    o.CompleteAsAsyncDone(this);

                }
            }
        }
    }
}