using System.Data;
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
    public partial class EstadoPacientes : System.Web.UI.Page
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

                //    string idDetalle = Request.QueryString["IdDetalle"];

                //    if (idDetalle != null)
                //    {
                //        BuscarDetalle(idDetalle);
                //    }
                //}
            }
        }

        private void BuscarDetalle(string idDetalle)
        {  
            EstadoPaciente estado = new EstadoPaciente();
            if (estado.Buscar(int.Parse(idDetalle)))
            {
                PacientesDropDownList.SelectedValue = estado.IdPaciente.ToString();
                SistemasDropDownList.SelectedValue = estado.DetalledEstadoPaciente.ToString();
                TextBoxId.Text = estado.IdEstado.ToString();
                FechaTextBox.Text = estado.fecha.ToString("yyyy-MM-dd");
                

                DetalleGridView.DataSource = estado.DetalledEstadoPaciente;
                DetalleGridView.DataBind();
            }
        }
        

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            EstadoPaciente estado = new EstadoPaciente();

            if (Session["detalle"] != null)
            {
                estado = (EstadoPaciente)Session["detalle"];
            }

            estado.AgregarDetalledEstadoPaciente(0, int.Parse(SistemasDropDownList.SelectedValue), SituacionPacienteTextBox.Text); 

            DetalleGridView.DataSource = estado.DetalledEstadoPaciente;
            DetalleGridView.DataBind();
            Session["detalle"] = estado;
        }

        protected void GuardarEstadoButton_Click(object sender, EventArgs e)
        {
            EstadoPaciente estado = new EstadoPaciente();
            if (Session["detalle"] != null)
            {
                estado = (EstadoPaciente)Session["detalle"];
            }

            estado.IdPaciente = int.Parse(PacientesDropDownList.SelectedValue);
            estado.fecha = Convert.ToDateTime(FechaTextBox.Text);

            if (estado.Insertar())
            {
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
            Response.Redirect("/Registro/EstadoPaciente.aspx");
        }
    }
}