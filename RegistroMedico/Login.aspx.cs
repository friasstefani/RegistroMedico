using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;

namespace RegistroMedico
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Buttonlogon_Click(object sender, EventArgs e)
        {
            if (Usuario.Logon(TextBoxUsuario.Text, TextBoxClave.Text))
                Response.Redirect("menuPrincipal.aspx");            
        }
    }
}