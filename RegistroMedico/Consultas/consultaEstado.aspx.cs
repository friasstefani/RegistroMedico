using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;
using System.Data;
using System.Web.Security;

namespace RegistroMedico
{
    public partial class consultaEstado : System.Web.UI.Page
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
            string filtro = TextBoxfiltro.Text;
            DataTable dt = new DataTable();

            if (filtro.Length == 0)
            {
                dt = DetalleEstadoPaciente.BuscarCampos("*", "detalleestadopaciente ");
                if (dt.Rows.Count > 0)
                {
                    GridViewConsulta.DataSource = dt;
                    GridViewConsulta.DataBind();
                    MsJ.Text = "";
                }
            }
            else
            {

                if (DropDownListfiltro.SelectedValue == "1")
                {
                    dt = DetalleEstadoPaciente.BuscarCampos("*", "detalleestadopaciente where idestado=(select top(1)idestado from estadopaciente where IdPaciente=(select IdPaciente from datos where nombre like '%" + TextBoxfiltro.Text + "%'))");
                    if (dt.Rows.Count > 0)
                    {
                        GridViewConsulta.DataSource = dt;
                        GridViewConsulta.DataBind();
                        MsJ.Text = "";
                    }
                    else
                    {
                        MsJ.Text = "Digite El nombre Correcto";
                    }
                }
                else
                {
                    dt = DetalleEstadoPaciente.BuscarCampos(" * ", "detalleestadopaciente where idestado=(select top(1)idestado from estadopaciente where IdPaciente=(select IdPaciente from datos where Cedula like '%" + TextBoxfiltro.Text + "%'))");
                    if (dt.Rows.Count > 0)
                    {
                        GridViewConsulta.DataSource = dt;
                        GridViewConsulta.DataBind();
                        MsJ.Text = "";
                    }
                    else
                    {
                        MsJ.Text = "Digite la ceula correcta";
                    }
                }
            }
      
            //select * from detalleestadopaciente where idestado=(select top(1)idestado from estadopaciente where IdPaciente=(select IdPaciente from datos where nombre='mizadlo'))
        }
    }
}