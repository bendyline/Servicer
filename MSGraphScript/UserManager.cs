using System;
using System.Serialization;

namespace BL.Servicer.MSGraph
{
    public class UserManager
    {
        private Graph graph;
        private Operation getCurrentUserOperation;
        private Microsoft.Graph.User currentUser;

        private bool isAuthenticated = false;
       
        public Microsoft.Graph.User CurrentUser
        {
            get
            {
                return this.currentUser;
            }
        }

        public UserManager(Graph graph)
        {
            this.graph = graph;
        }


        public void GetCurrentUser(AsyncCallback callback, object state)
        {
            if (this.currentUser != null)
            {
                CallbackResult.NotifySynchronousSuccess(callback, state, currentUser);

                return;
            }

            bool isNew = false;

            if (this.getCurrentUserOperation == null)
            {
                this.getCurrentUserOperation = new Operation();
                isNew = true;
            }

            this.getCurrentUserOperation.AddCallback(callback, state);

            if (isNew)
            {
             
                HttpRequest wr = new HttpRequest();

                this.getCurrentUserOperation.Tag = wr;

                wr.Operation = this.getCurrentUserOperation;

                wr.SetBearerToken(Graph.Current.AccessToken);

                wr.OnComplete = new Action(this.EndCurrentUserGet);

                wr.Url = this.graph.BaseUrl + "v1.0/me/";
                wr.RequestType = HttpRequestType.JsonRead;

                wr.Send();
            }
        }

        public void EndCurrentUserGet()
        {
            Operation o = this.getCurrentUserOperation;
     
            if (o == null)
            {
                return;
            }

            this.getCurrentUserOperation = null;

            HttpRequest wr = (HttpRequest)o.Tag;

            this.currentUser = (Microsoft.Graph.User)wr.ResponseJson;
        }
    }
}
