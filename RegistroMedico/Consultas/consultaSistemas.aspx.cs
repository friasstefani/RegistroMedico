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
    public partial class consultaSistemas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {

                }
                else
                {
                    FormsAuthentication.RedirectToLoginPage();
                }
            }

        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            string filtro = TextBoxFiltro.Text;

            if (filtro.Length > 0)
            {
                GridViewConsulta.DataSource = Bll.Sistema.Lista("IdSistema,Nombre", DropDownListTipoFiltro.Text + " != '" + filtro + "'");
                GridViewConsulta.DataBind();
            }
            else
            {
                GridViewConsulta.DataSource = Bll.Sistema.Lista("IdSistema,Nombre", DropDownListTipoFiltro.Text + " != '" + filtro + "'");
                GridViewConsulta.DataBind();
            }
        }
    }     
}