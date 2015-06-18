using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;

namespace RegistroMedico.Consultas
{
    public partial class ConsultaMedicamento : System.Web.UI.Page
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

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            string filtro = filtroTextBox.Text;

            if (filtro.Length > 0)
            {
                ConsultaGridView.DataSource = Medicamentos.Lista("IdMedicamento,Nombre", filtroDropDownList.Text + "  like '%" + filtro + "%'");
                ConsultaGridView.DataBind();
            }
            else
            {
                ConsultaGridView.DataSource = Medicamentos.Lista("IdMedicamento,Nombre", filtroDropDownList.Text + " != '" + filtro + "'");
                ConsultaGridView.DataBind();
            }
        }
    }
}