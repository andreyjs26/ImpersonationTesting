using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Security.Principal;
using System.Web.Configuration;

namespace testImpersonation
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            
            string username="AMERICAS"+@"\"+Login1.UserName.ToString();

                
            string password= Login1.Password.ToString();

            saveIdentity(username, password, true);
            
                Response.Redirect("WebForm1.aspx");
          

                

	


           
            
        }



        public void saveIdentity(string username, string password, bool impersonate)
        {
            Configuration objConfig = WebConfigurationManager.OpenWebConfiguration("~");
            IdentitySection identitySection = (IdentitySection)objConfig.GetSection("system.web/identity");
            if (identitySection != null)
            {
                identitySection.UserName = username;
                identitySection.Password = password;
                identitySection.Impersonate = impersonate;
            }
            objConfig.Save();
        }

    }
}