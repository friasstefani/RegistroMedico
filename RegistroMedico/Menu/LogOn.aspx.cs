using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;
using System.Web.Security;


namespace RegistroMedico
{
    public partial class LogOn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Buttonlogon_Click(object sender, EventArgs e)
        {
            if (Usuario.Logon(TextBoxUsuario.Text, TextBoxClave.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(TextBoxUsuario.Text, true);
                Response.Redirect("/Menu/menuPrincipal.aspx");  
            }
        }
    }
}