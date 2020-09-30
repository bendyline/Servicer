/* Copyright (c) Bendyline LLC. All rights reserved. Licensed under the Apache License, Version 2.0.
    You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0. */

using BL.Data;
using Microsoft.Graph;
using System;
using System.Collections.Generic;

#if NET
using Bendyline.Base;
using Bendyline.Base.ScriptCompatibility;

namespace Bendyline.Data
#elif SCRIPTSHARP

namespace BL.Servicer.MSGraph
#endif
{
    public class ItemTypeList : IDataStoreType
    {
        private List<IDataStoreField> fields;
        private Dictionary<String, Field> fieldsByName;
        private Dictionary<String, ListItem> itemsById;
        private List<IItem> items;
        private String name;
        private Dictionary<String, ListItemSet> itemsByQuery;
        private ListItemSet allItemsSet;
        private ListStore store;
        private String entitySetName;
        private String keyFieldId;
        private String titleFieldId;
        private bool isProvisioned = false;
        private Query validCriteria;
        private HttpRequest listRetrieveRequest;
        private HttpRequest listCreateRequest;
        private List<IDataStoreField> fieldsToCreate;

        private Operation ensureProvisionedOperation;

        private String description;
        private string titleText;

        public bool IsProvisioned
        {
            get
            {
                return this.isProvisioned;
            }

            set
            {
                this.isProvisioned = value;
            }
        }

        public String Title
        {
            get
            {
                return this.titleText;
            }

            set
            {
                this.titleText = value;
            }
        }

        public String Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.description = value;
            }
        }


        public String TitleFieldId
        {
            get
            {
                return this.titleFieldId;
            }

            set
            {
                this.titleFieldId = value;
            }
        }

        public String KeyFieldId
        {
            get
            {
                return this.keyFieldId;
            }
            set
            {
                this.keyFieldId = value;
            }
        }

        public Query ValidCriteria
        {
            get
            {
                return this.validCriteria;
            }

            set
            {
                this.validCriteria = value;
            }
        }

        public ICollection<IDataStoreField> Fields 
        {
            get
            {
                return this.fields;
            }
        }

        public ICollection<IItem> AllLocalItems 
        {
            get
            {
                return this.items;
            }     
        }

        public IDataStore Store
        {
            get
            {
                return this.store;
            }
        }

        public String Name 
        {
            get
            {
                return this.name;
            }
        }

        public String GraphUrl
        {
            get
            {
                String graphUrl = this.store.SiteListsRootGraphUrl;

                if (!String.IsNullOrEmpty(this.store.ListNamespace))
                {
                    graphUrl += this.store.ListNamespace;
                }

                return graphUrl + this.name;
            }
        }

        public ItemTypeList(ListStore store, String name)
        {
            this.name = name;
            this.store = store;
            this.fieldsByName = new Dictionary<string, Field>();
            this.itemsByQuery = new Dictionary<string, ListItemSet>();
            this.fields = new List<IDataStoreField>();
            this.itemsById = new Dictionary<String, ListItem>();
            this.items = new List<IItem>();
        }

        public IDataStoreField AssumeField(String name, FieldType fieldType)
        {
            Field f = (Field)this.GetField(name);

            if (f == null)
            {
                f = new Field(name, fieldType);

                this.fieldsByName[name] = f;
                this.fields.Add(f);
            }

            return f;
        }

        public IDataStoreField GetField(String fieldName)
        {
            return this.fieldsByName[fieldName];
        }

        public IItem CreateItem()
        {
            ListItemSet itemSet = (ListItemSet)this.EnsureAllItemsSet();
            
            return itemSet.Create();
        }

        public IItem CreateDisconnectedItem()
        {
            ListItem item = new ListItem(this);

            item.Disconnected = true;
            item.SetCreatedDateTime(Date.Now);
            item.SetModifiedDateTime(item.CreatedDateTime);
;
            return item;
        }

        public void Save()
        {
            foreach (ListItem ode in this.allItemsSet.Items)
            {
                ode.Save(null, null);
            }
        }

        public IDataStoreItemSet EnsureAllItemsSet()
        {
            if (this.allItemsSet != null)
            {
                return this.allItemsSet;
            }

            String queryString = "";

            ListItemSet odis = this.itemsByQuery[queryString];

            if (odis == null)
            {
                odis = new ListItemSet(this, Query.All);

                this.itemsByQuery[queryString] = odis;
            }


            this.allItemsSet = odis;
            return odis;
        }

        public ListItem EnsureItem(String id)
        {
            if (this.itemsById.ContainsKey(id))
            {
                return this.itemsById[id];
            }

            ListItem item = new ListItem(this);

            item.SetId(id);

            this.itemsById[id] = item;
            this.items.Add(item);

            return item;
        }

        public void UpdateItemInItemSets(ListItem item)
        {
            foreach (String key in this.itemsByQuery.Keys)
            {
                ListItemSet odis = this.itemsByQuery[key];

                // don't mess with arbitrarily query items, like the MyItems query
                if (String.IsNullOrEmpty(odis.Query.Source))
                {
                    // should this item be in this item set?
                    if (odis.GetItemByLocalOnlyUniqueId(item.LocalOnlyUniqueId) == null && odis.Query.ItemMatches(item))
                    {
                        odis.Add(item);
                    }
                    // or should this item be removed from this set?
                    else if (odis.GetItemByLocalOnlyUniqueId(item.LocalOnlyUniqueId) != null && !odis.Query.ItemMatches(item))
                    {
                        odis.Remove(item);
                    }
                }
            }
        }

        public void MoveItemSetToNewQuery(ListItemSet odis, Query newQuery)
        {
            String oldQueryString = odis.Query.ToString().ToLowerCase();

            this.itemsByQuery.Remove(oldQueryString);

            odis.Query = newQuery;

            String newQueryString = newQuery.ToString().ToLowerCase();

            this.itemsByQuery[newQueryString] = odis;
        }

        public IDataStoreItemSet EnsureItemSet(Query query)
        {
            String queryString = query.ToString().ToLowerCase();

            ListItemSet odis = this.itemsByQuery[queryString];

            if (odis == null)
            {
                odis = new ListItemSet(this, query);

                this.itemsByQuery[queryString] = odis;
            }

            return odis;
        }

        public void SetDataForQuery(Query query, object data)
        {
            ListItemSet dataSet = (ListItemSet)EnsureItemSet(query);

            dataSet.SetFromData(data);
        }

        public void BeginUpdate(AsyncCallback callback, object asyncState)
        {
            ;
        }

        public void EnsureProvisioned(AsyncCallback callback, object state)
        {
            bool isNew = false;

            if (this.IsProvisioned)
            {
                CallbackResult.NotifySynchronousSuccess(callback, state, this);

                return;
            }

            if (this.ensureProvisionedOperation == null)
            {
                this.ensureProvisionedOperation = new Operation();
                isNew = true;
            }

            this.ensureProvisionedOperation.AddCallback(callback, state);

            if (isNew)
            {
                this.ValidateList();
            }
        }

        private void ValidateList()
        {
            String endpoint = this.GraphUrl + "?expand=columns";

            this.listRetrieveRequest = new HttpRequest();

            this.listRetrieveRequest.AuthenticationRequired = false;
            this.listRetrieveRequest.SetBearerToken(this.store.Graph.AccessToken);

            this.listRetrieveRequest.Source = this;
            this.listRetrieveRequest.OnComplete = new Action(this.EndListRetrieve);
            this.listRetrieveRequest.OnError = new ErrorAction(this.HandleListRetrieveError);

            this.listRetrieveRequest.Url = endpoint;
            this.listRetrieveRequest.RequestType = HttpRequestType.JsonRead;

            this.listRetrieveRequest.Send();
        }

        private void HandleListRetrieveError(String errorCode, String errorMessage)
        {
            if (errorCode == "404")
            {
                this.listCreateRequest = new HttpRequest();

                this.listCreateRequest.AuthenticationRequired = false;
                this.listCreateRequest.SetBearerToken(this.store.Graph.AccessToken);

                this.listCreateRequest.Source = this;
                this.listCreateRequest.OnComplete = new Action(this.EndListCreate);
                this.listCreateRequest.OnError = new ErrorAction(this.ListCreateError);

                this.listCreateRequest.Url = this.store.SiteListsRootGraphUrl;
                this.listCreateRequest.RequestType = HttpRequestType.JsonWrite;

                this.listCreateRequest.Verb = "POST";

                String columnJson = String.Empty;

                foreach (IDataStoreField field in this.Fields)
                {
                    if (!String.IsNullOrEmpty(columnJson))
                    {
                        columnJson += ",";
                    }

                    if (field.Name != "Id" && field.Name != "Title")
                    {
                        columnJson += GetColumnJson(field);
                    }
                }

                String listCreateContent = "{\"displayName\": \"" + this.name + "\",";
                listCreateContent += "\"columns\": [" + columnJson + "],";
                listCreateContent += "\"list\": {\"template\": \"genericList\"}";
                listCreateContent += "}";

                this.listCreateRequest.Body = listCreateContent;

                this.listCreateRequest.Send();
            }
        }
        private void EndListCreate()
        {
            this.CompleteListProvisioned();
        }

        private void ListCreateError(String errorCode, String errorMessage)
        {
            Log.DebugAlert("List creation error: " + errorCode + "|" + errorMessage);
        }

        private void EndListRetrieve()
        {
            Microsoft.Graph.List list = (Microsoft.Graph.List)this.listRetrieveRequest.ResponseJson;

            // check to see if we have all the required fields
            this.fieldsToCreate = new List<IDataStoreField>();

            foreach (IDataStoreField field in this.fields)
            {
                this.fieldsToCreate.Add(field);
            }

            foreach (ListColumn lc in list.Columns)
            {
                for (int i=0; i<fieldsToCreate.Count; i++)
                {
                    if (fieldsToCreate[i].Name == lc.Name)
                    {
                        fieldsToCreate.Remove(fieldsToCreate[i]);
                        i--;
                    }
                }
            }

            this.EnsureMissingFields();
        }

        // create the necessary fields, one at a time.
        private void CreateNextMissingField()
        {
            if (this.fieldsToCreate.Count == 0)
            {
                return;
            }

            IDataStoreField fieldToCreate = this.fieldsToCreate[0];

            this.fieldsToCreate.Remove(fieldToCreate);

            String endpoint = this.GraphUrl + "/columns";

            this.listRetrieveRequest = new HttpRequest();

            this.listRetrieveRequest.AuthenticationRequired = false;
            this.listRetrieveRequest.SetBearerToken(this.store.Graph.AccessToken);

            this.listRetrieveRequest.Verb = "POST";
            this.listRetrieveRequest.Url = endpoint;

            this.listRetrieveRequest.Body = GetColumnJson(fieldToCreate);
            this.listRetrieveRequest.Source = this;
            this.listRetrieveRequest.OnComplete = new Action(this.EnsureMissingFields);

            this.listRetrieveRequest.RequestType = HttpRequestType.JsonWrite;

        }

        public String GetColumnJson(IDataStoreField field)
        {
            String json = "{";

            json += "\"name\":\"" + field.Name + "\",";
            json += "\"id\":\"" + field.Name + "\",";
            json += "\"displayName\":\"" + field.DisplayName + "\",";

            switch (field.Type)
            {
                case FieldType.BoolChoice:
                    json += "\"boolean\": {}";
                    break;

                case FieldType.DateTime:
                    json += "\"dateTime\": {}";
                    break;

                case FieldType.Geopoint:
                    json += "\"geolocation\": {}";
                    break;

                case FieldType.Integer:
                case FieldType.BigInteger:
                case FieldType.BigNumber:
                    json += "\"number\": {}";
                    break;

                default:
                    json += "\"text\": {}";
                    break;
            }

            json += "}";

            return json;
        }

        private void EnsureMissingFields()
        {
            if (this.fieldsToCreate.Count >= 0)
            {
                this.CreateNextMissingField();
            }
            else
            {
                this.CompleteListProvisioned();
            }
        }

        private void CompleteListProvisioned()
        {
            if (this.ensureProvisionedOperation != null)
            {
                Operation o = this.ensureProvisionedOperation;

                this.ensureProvisionedOperation = null;

                o.CompleteAsAsyncDone(this);
            }
        }

        private void ListProvisionedComplete(IAsyncResult result)
        {
            if (this.ensureProvisionedOperation != null && this.IsProvisioned)
            {
                this.isProvisioned = true;

                this.ensureProvisionedOperation.CompleteAsAsyncDone(this);

                this.ensureProvisionedOperation = null;
            }
        }
    }
}
