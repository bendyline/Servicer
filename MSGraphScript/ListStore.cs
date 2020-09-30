/* Copyright (c) Bendyline LLC. All rights reserved. Licensed under the Apache License, Version 2.0.
    You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0. */

using BL.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;


#if NET
using Bendyline.Base;

namespace Bendyline.Data
#elif SCRIPTSHARP

namespace BL.Servicer.MSGraph
#endif
{
    public class ListStore : IDataStore
    {
        private String location;
        private String name;
        private List<IDataStoreType> itemTypeLists;
        private Dictionary<String, ItemTypeList> itemTypeListsByName;
        private bool requiresAuthentication;
        private Int32 newItemsCreated;
        private String listNamespace;
        public Graph graph;
        private Operation ensureProvisionedOperation;


        public Graph Graph
        {
            get
            {
                return this.graph;
            }

            set
            {
                this.graph = value;
            }
        }


        public ICollection<IDataStoreType> Types 
        {
            get
            {
                return this.itemTypeLists;
            }        
        }

        public bool IsProvisioned
        {
            get
            {
                foreach (ItemTypeList itl in this.itemTypeLists)
                {
                    if (!itl.IsProvisioned)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public String Name 
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }
        
        /// <summary>
        /// This is the server-relative URL of the SharePoint site that hosts respective lists.
        /// </summary>
        public String Location 
        {
            get
            {
                return this.location;
            }

            set
            {
                this.location = value;
            }
        }

        public String ListNamespace
        {
            get
            {
                return this.listNamespace;
            }
            set
            {
                this.listNamespace = value;
            }
        }

        public int NewItemsCreated
        {
            get
            {
                return this.newItemsCreated;
            }

            set
            {
                this.newItemsCreated = value;
            }
        }

        public bool RequiresAuthentication 
        {
            get
            {
                return this.requiresAuthentication;
            }
            set
            {
                this.requiresAuthentication = value;
            }
        }

        public String SiteListsRootGraphUrl
        {
            get
            {
                Debug.Assert(this.Location != null, "Attempting to use a List Store that hasn't been configured.");

                return Graph.Current.BaseUrl + "v1.0/sites/root:" + UrlUtilities.EnsurePathDoesNotEndWithSlash(this.Location) + ":/lists/";
            }
        }

        public ListStore()
        {
            this.itemTypeLists = new List<IDataStoreType>();
            this.itemTypeListsByName = new Dictionary<string, ItemTypeList>();
        }

        public IDataStoreType Type(String typeName)
        {
            ItemTypeList entity = this.itemTypeListsByName[typeName];

            if (entity == null)
            {
                entity = new ItemTypeList(this, typeName);
                this.itemTypeListsByName[typeName] = entity;
                this.itemTypeLists.Add(entity);
            }

            return entity;
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
                foreach (ItemTypeList itl in this.itemTypeLists)
                {
                    itl.EnsureProvisioned(this.ListProvisionedComplete, null);
                }
            }
        }

        private void ListProvisionedComplete(IAsyncResult result)
        {
            if (this.ensureProvisionedOperation != null && this.IsProvisioned)
            {
                this.ensureProvisionedOperation.CompleteAsAsyncDone(this);

                this.ensureProvisionedOperation = null;
            }
        }

        public void Save()
        {
            foreach (ItemTypeList e in this.itemTypeLists)
            {
                e.Save();
            }
        }
    }
}
