using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;

namespace RegistroMedico
{
    public partial class consultaPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            string filtro = TextBoxFiltro.Text;

            if( filtro.Length > 0)
            {
                GridViewConsulta.DataSource = Paciente.Lista("idPaciente,Nombre,apellido,Telefono,Celular,Direccion,cedula,sexo,ocupacion,fechanacimiento, fechaingreso", DropDownListTipoFiltro.Text + "  like '%" + filtro + "%'");
                GridViewConsulta.DataBind();
            }
            else
            {
                GridViewConsulta.DataSource = Paciente.Lista("idPaciente,Nombre,apellido,Telefono,Celular,Direccion,cedula,sexo,ocupacion,fechanacimiento, fechaingreso", DropDownListTipoFiltro.Text + " != '" + filtro + "'");
                GridViewConsulta.DataBind();
            }
        }
    }
}