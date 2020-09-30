using System;

namespace BL.Servicer.MSGraph
{
    public class Graph 
    {
        private static Graph current;
        private UserManager users;
        private String accessToken;

        public String BaseUrl
        {
            get
            {
                return "https://graph.microsoft.com/";
            }
        }

        public String AccessToken
        {
            get
            {
                return this.accessToken;
            }

            set
            {
                this.accessToken = value;
            }
        }

        public UserManager Users
        {
            get
            {
                return this.users;
            }
        }

        public static Graph Current
        {
            get
            {
                if (current == null)
                {
                    current = new Graph();
                }

                return current;
            }
        }

        public Graph()
        {
            this.users = new UserManager(this);
        }
    }
}
