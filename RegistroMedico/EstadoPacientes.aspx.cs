using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;
namespace RegistroMedico
{
    public partial class EstadoPacientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PacientesDropDownList.DataSource = Bll.Paciente.Lista("IdPaciente,Nombre", "IdPaciente > 0");
                PacientesDropDownList.DataValueField = "IdPaciente";
                PacientesDropDownList.DataTextField = "Nombre";
                PacientesDropDownList.DataBind();

                SistemasDropDownList.DataSource = Bll.Sistema.Lista("IdSistema,Nombre", "IdSistema > 0");
                SistemasDropDownList.DataValueField = "IdSistema";
                SistemasDropDownList.DataTextField = "Nombre";
                SistemasDropDownList.DataBind();
            }
        }
        

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            DataTable detalle = new DataTable();

            if (Session["detalle"] == null)
            {
                detalle.Columns.Add("IdSistema", typeof(int));
                detalle.Columns.Add("NombreSistema", typeof(string));
                detalle.Columns.Add("SituacionPaciente", typeof(string));
            }
            else
            {
                detalle = (DataTable)Session["detalle"];
            }


            DataRow row = detalle.NewRow();
            row["IdSistema"] = SistemasDropDownList.SelectedValue;
            row["NombreSistema"] = SistemasDropDownList.SelectedItem;
            row["SituacionPaciente"] = SituacionPacienteTextBox.Text;
            detalle.Rows.Add(row);

            Session["detalle"] = detalle;
            DetalleGridView.DataSource = detalle;
            DetalleGridView.DataBind();
        }

        protected void GuardarEstadoButton_Click(object sender, EventArgs e)
        {
            EstadoPaciente estado = new EstadoPaciente();

            estado.IdPaciente = int.Parse(PacientesDropDownList.SelectedValue);
            estado.fecha = Convert.ToDateTime(FechaTextBox.Text);

            if (Session["detalle"] != null)
            {
                DataTable detalle = new DataTable();
                detalle = (DataTable)Session["detalle"];

                foreach (DataRow dt in detalle.Rows)
                {
                    estado.AgregarDetalledEstadoPaciente(0, int.Parse(dt["IdSistema"].ToString()), dt["SituacionPaciente"].ToString());
                }

                if (estado.Insertar())
                    MsjLabel.Text = "Guardado correctamente";
            }
            else
            {
                MsjLabel.Text = "no puede guardar un estado de paciente vacio";
            }
        }

        protected void Buttonelimina_Click(object sender, EventArgs e)
        {
            EstadoPaciente estado  = new EstadoPaciente ();
            int codigo = 0;
            int.TryParse(Session["Codigo"].ToString(), out codigo);

            if (estado.Eliminar(codigo))
            {
                MsjLabel.Text = "Eliminado correctamente";
            }
           /* DataTable detalle = new DataTable(); otro metedo que estaba probando
            detalle = (DataTable)Session["detalle"];

            detalle.Rows.RemoveAt(Eliminar(detalle));
        }
        int Eliminar(DataTable detalle)
        {
            if (detalle.Rows.Count > 0)
                return detalle.Rows.Count - 1;
            else
                return 0;*/
        }

        protected void Buttonnuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("/EstadoPaciente.aspx");
        }
    }
}