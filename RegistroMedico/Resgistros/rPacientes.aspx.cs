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
    public partial class rPacientes : System.Web.UI.Page
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
                if (Request.QueryString["IdPaciente"] != null)
                {
                    int codigo = 0;
                    int.TryParse(Request.QueryString["IdPaciente"].ToString(), out codigo);
                    BuscarPaciente(codigo);

                }

                if (TextBoxId.Text == string.Empty)
                {
                    Buttoneliminar.Enabled = false;
                }
                else
                {
                    Buttoneliminar.Enabled = true;
                }
            }
        }

        protected void Buttonnuevo_Click(object sender, EventArgs e)
        {

            Response.Redirect("/Pacientes.aspx");
        }


        protected void Buttoneliminar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            int codigo = 0;
            int.TryParse(TextBoxId.Text, out codigo);

            if (paciente.Eliminar(codigo))
            {
                LabelMesaage.Text = "Eliminado correctamente";
            }
        }

        protected void Buttonguardar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();

            paciente.Nombre = TextBoxnombre.Text;
            paciente.Apellido = TextBoxapellido.Text;
            paciente.Direccion = TextBoxdireccion.Text;
            paciente.Celular = TextBoxcelular.Text;
            paciente.Telefono = TextBoxtelefono.Text;
            paciente.cedula = TextBoxcedula.Text;
            paciente.sexo = DropDownListsexo.Text;
            paciente.fechanacimiento = Convert.ToDateTime(TextBoxnacimiento.Text);
            paciente.fechaingreso = Convert.ToDateTime(TextBoxingreso.Text);
            paciente.ocupacion = TextBoxocupacion.Text;

            if (Session["Codigo"] == null)
            {
                if (paciente.Insertar())
                {
                    LabelMesaage.Text = "Guardado correctamente";
                }
            }
            else
            {
                int id = Convert.ToInt32(Session["Codigo"]);
                if (paciente.Modificar(id))
                {
                    LabelMesaage.Text = "Modificado correctamente";
                }
            }
        }

        public void BuscarPaciente(int codigo)
        {
            Paciente paciente = new Paciente();

            if (paciente.Buscar(codigo))
            {
                Session["Codigo"] = paciente.Idpaciente;
                TextBoxId.Text = paciente.Idpaciente.ToString();
                TextBoxnombre.Text = paciente.Nombre;
                TextBoxapellido.Text = paciente.Apellido;
                TextBoxdireccion.Text = paciente.Direccion;
                TextBoxcelular.Text = paciente.Celular;
                TextBoxtelefono.Text = paciente.Telefono;
                TextBoxcedula.Text = paciente.cedula;
                DropDownListsexo.Text = paciente.sexo;
                TextBoxnacimiento.Text = paciente.fechanacimiento.ToString("yyyy-MM-dd");
                TextBoxingreso.Text = paciente.fechaingreso.ToString("yyyy-MM-dd");
                TextBoxocupacion.Text = paciente.ocupacion;

            }
            else
            {
                LabelMesaage.Text = ("Paiente no existe");
            }

        }
    }
}