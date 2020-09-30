using Msal;
using System;
using System.Diagnostics;
using System.Html;
using System.Serialization;

namespace BL.Servicer.MSIdentity
{
    public class Identity 
    {
        private String appId;
        private String[] scopes;
        private UserAgentApplication userAgentApp;
        private static Identity currentIdentity;
        private bool isAuthenticated;
        private Operation authenticateOperation;
        private Account account;
        private AuthResponse authResponse;
        private bool isSignedIn = false;

        public static Identity Current
        {
            get
            {
                if (currentIdentity == null)
                {
                    currentIdentity = new Identity();
                }

                return currentIdentity;
            }
        }

        public String[] Scopes
        {

            get
            {
                return this.scopes;
            }

            set
            {
                this.scopes = value;
            }

        }

        public Account Account
        {
            get
            {
                if (this.authResponse != null && this.authResponse.Account != null)
                {
                    return this.authResponse.Account;
                }

                return this.account;
            }
        }

        public String AppId
        {
            get
            {
                return this.appId;
            }

            set
            {
                this.appId = value;
            }
        }


        public String AccessToken
        {
            get
            {
                if (this.authResponse == null)
                {
                    return null;
                }

                return this.authResponse.AccessToken;
            }
        }

        public void Authenticate(AsyncCallback callback, object state)
        {
            if (this.isAuthenticated)
            {
                CallbackResult.NotifySynchronousSuccess(callback, state, this);

                return;
            }

            bool isNew = false;

            if (this.authenticateOperation == null)
            {
                this.authenticateOperation = new Operation();
                isNew = true;
            }

            this.authenticateOperation.AddCallback(callback, state);

            if (isNew)
            {
                Config c = new Config();

                c.Auth = new ConfigAuthentication();
                c.Auth.ClientId = this.appId;

                c.Cache = new ConfigCache();
                c.Cache.CacheLocation = "localStorage";

                this.userAgentApp = new UserAgentApplication(c);

                this.AcquireTokenAfterSignIn();

            }
        }

        private void SignIn()
        {
            LoginRequest lr = new LoginRequest();

            lr.Scopes = new String[] { "openid", "profile", "User.Read" };

            this.userAgentApp.LoginPopup(lr).Then(this.HandleLoginResponse).Catch(this.HandleLoginOrAuthFailed);
        }

        private void HandleLoginResponse(AuthResponse response)
        {
            this.account = response.Account;

            this.isSignedIn = true;

            this.AcquireTokenAfterSignIn();
        }

        private void HandleLoginOrAuthFailed(AuthResponse response)
        {
            Debug.Fail("Unsucessfully signed in " + Json.Stringify(response));
        }

        private void AcquireTokenAfterSignIn()
        {
            TokenRequest lr = new TokenRequest();

            lr.Scopes = this.scopes;
            
            this.userAgentApp.AcquireTokenSilent(lr).Then(this.HandleAuthResponse).Catch(this.HandleTokenSilentFailed);
        }

        private void HandleTokenSilentFailed(AuthResponse response)
        {
            
            if (!this.isSignedIn)
            {
                this.SignIn();
                return;
            }


            TokenRequest lr = new TokenRequest();

            lr.Scopes = this.scopes;

            this.userAgentApp.AcquireTokenPopup(lr).Then(this.HandleAuthResponse).Catch(this.HandleLoginOrAuthFailed);
        }

        private void HandleAuthResponse(AuthResponse response)
        {
            this.isAuthenticated = true;

            this.authResponse = response;

            Window.SetTimeout(new Action(this.CompleteOperation), 1);
        }

        private void CompleteOperation()
        {
            Operation o = this.authenticateOperation;

            this.authenticateOperation = null;

            o.CompleteAsAsyncDone(this);
        }
    }
}
/*

myMSALObj.acquireTokenSilent(request)
    .catch(error => {
      console.log(error);
      console.log("silent token acquisition fails. acquiring token using popup");

      // fallback to interaction when silent call fails
        return myMSALObj.acquireTokenPopup(request)
          .then(tokenResponse => {
            return tokenResponse;
          }).catch(error => {
            console.log(error);
          });
    });



 myMSALObj.loginPopup(loginRequest)
    .then(loginResponse => {
      console.log('id_token acquired at: ' + new Date().toString());
      console.log(loginResponse);

      if (myMSALObj.getAccount()) {
        showWelcomeMessage(myMSALObj.getAccount());
      }
    }).catch(error => {
      console.log(error);
    });




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

    ((ODataEntityType)this.Type).UpdateItemInItemSets(this);

    this.SendSaveRequest();
}

private void SendSaveRequest()
{
    String endpoint = ((ODataEntityType)this.Type).Url;

    HttpRequest xhr = new HttpRequest();

    if (this.LocalStatus == ItemLocalStatus.Update || this.LocalStatus == ItemLocalStatus.Deleted)
    {
        xhr.Open("PUT", endpoint + "(" + this.Id + "L)");
    }
    else
    {
        xhr.Open("POST", endpoint);
    }

    xhr.Initialize(HttpRequestType.JsonWrite);

    //            xhr.SetRequestHeader("DataServiceVersion", "DataServiceVersion: 3.0;NetFx");
    xhr.OnReadyStateChange = new Action(this.HandleSaveComplete);

    this.saveRequest = xhr;

    xhr.SendWithBody(this.activeSaveJson);
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
                        }}

                if ({2}==0 && oc[""Id""] !=null)
                {{
                    this.setId(oc[""Id""]);
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
}*/