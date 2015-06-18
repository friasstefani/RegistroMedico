using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroMedico
{
    public partial class Medicamento : System.Web.UI.Page
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
                if (Request.QueryString["codigo"] != null)
                {
                    int codigo = 0;
                    int.TryParse(Request.QueryString["codigo"].ToString(), out codigo);
                    BuscarMedicamento(codigo);

                }

                if (IdMedicamentoTextBox.Text == string.Empty)
                {
                    ElininarButton.Enabled = false;
                }
                else
                {
                    ElininarButton.Enabled = true;
                }
            }
        }

        public void BuscarMedicamento(int codigo)
        {
            Bll.Medicamentos Medicamento = new Bll.Medicamentos();

            if (Medicamento.Buscar(codigo))
            {
                Session["Codigo"] = Medicamento.IdMedicamento;
                IdMedicamentoTextBox.Text = Medicamento.IdMedicamento.ToString();
                NombreTextBox.Text = Medicamento.Nombre; 
            }
            else
            {
         LabelMesaage.Text = ("Paiente no existe");
            }

        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Resgistros/Medicamentos.aspx");
        }

        protected void ElininarButton_Click(object sender, EventArgs e)
        {
            Bll.Medicamentos Medicamento = new Bll.Medicamentos();
            int codigo = 0;
            int.TryParse(IdMedicamentoTextBox.Text, out codigo);

            if (Medicamento.Eliminar(codigo))
            {
             LabelMesaage.Text = "Eliminado correctamente";
            }
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Bll.Medicamentos Medicamento = new Bll.Medicamentos();

            Medicamento.Nombre = NombreTextBox.Text;

            if (Session["codigo"] == null)
            {
                if (Medicamento.Insertar())
                {
                    LabelMesaage.Text = "Guardado correctamente";
                }
            }
            else
            {
                int id = Convert.ToInt32(Session["codigo"]);
                if (Medicamento.Modificar(id))
                {
                   LabelMesaage.Text = "Modificado correctamente";
                }
            }
        }
    }

}