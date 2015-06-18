using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroMedico
{
    public partial class menuPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    //djasdhka
                }
                else
                {
                    FormsAuthentication.RedirectToLoginPage();
                }
            }
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
}