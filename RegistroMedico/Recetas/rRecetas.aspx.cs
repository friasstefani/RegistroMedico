using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;

namespace RegistroMedico.Recetas
{
    public partial class rRecetas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            MedicamentosDropDownList.DataSource = Medicamentos.Lista("IdMedicamento,Nombre", "IdMedicamento > 0");
            MedicamentosDropDownList.DataValueField = "IdMedicamento";
            MedicamentosDropDownList.DataTextField = "Nombre";
            MedicamentosDropDownList.DataBind();

            PacienteDropDownList.DataSource = Paciente.Lista("IdPaciente,Nombre", "IdPaciente > 0");
            PacienteDropDownList.DataValueField = "IdPaciente";
            PacienteDropDownList.DataTextField = "Nombre";
            PacienteDropDownList.DataBind();

        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Recetas/rRecetas.aspx");
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            EncabezadoRecetas receta = new EncabezadoRecetas();

            if (Session["detalle"] != null)
            {
                receta = (EncabezadoRecetas)Session["detalle"];
            }

            receta.AgregarDetalleRecetas(0,0,int.Parse(MedicamentosDropDownList.SelectedValue),DescripcionTextBox.Text,float.Parse(CantidadTextBox.Text ));
            
            DatosGridView.DataSource = receta.DetalleRecetas;
            DatosGridView.DataBind();
            Session["detalle"] = receta;
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {

            EncabezadoRecetas receta = new EncabezadoRecetas();

            receta.IdPaciente = int.Parse(PacienteDropDownList.SelectedValue);
            receta.fecha = Convert.ToDateTime(FechaTextBox.Text);

            if (Session["detalle"] != null)
            {
                receta = (EncabezadoRecetas)Session["detalle"];

                if (receta.Insertar())
                    MsjLabel.Text = "Guardado correctamente";
            }
            else
            {
                MsjLabel.Text = "no puede guardar un estado de paciente vacio";
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            EncabezadoRecetas receta = new EncabezadoRecetas();

            int codigo = 0;
            int.TryParse(Session["Codigo"].ToString(), out codigo);

            if (receta.Eliminar(codigo))
            {
                MsjLabel.Text = "Eliminado correctamente";
            }
        }

        protected void DatosGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        } 

    }
}