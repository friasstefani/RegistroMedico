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
    public partial class Sistema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
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
                if (Request.QueryString["IdSistema"] != null)
                {
                    int codigo = 0;
                    int.TryParse(Request.QueryString["IdSistema"].ToString(), out codigo);
                    BuscarSistema(codigo);

                }

               if (TextBoxSistema.Text == string.Empty)
                {
                    ButtonEliminar.Enabled = false;
                }
                else
                {
                    ButtonEliminar.Enabled = true;
                }
            }
        }
        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
           Bll.Sistema s = new Bll.Sistema();
            int codigo = 0;
            int.TryParse(TextBoxSistema.Text, out codigo);
            BuscarSistema(codigo);
        }

        public void BuscarSistema(int codigo)
        {
          Bll.Sistema s = new Bll.Sistema();

            if (s.Buscar(codigo))
            {
                Session["Codigo"] = s.IdSistema;
                TextBoxSistema.Text = s.IdSistema.ToString();
                TextBoxnombresi.Text = s.Nombre;
            }
            else
            {
                Label.Text = ("Paiente no existe");
            }
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {    Bll.Sistema s = new Bll.Sistema();
             s.Nombre = TextBoxnombresi.Text;

            if (Session["Codigo"] == null)
            {
                if (s.Insertar())
                {
                    Label.Text = "Guardado correctamente";
                }
            }
            else
            {
                int id = Convert.ToInt32(Session["Codigo"]);
                if (s.Modificar(id))
                {
                    Label.Text = "Modificado correctamente";
                }
            }
             
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            Bll.Sistema s = new Bll.Sistema();
            int codigo = 0;
            int.TryParse(TextBoxSistema.Text, out codigo);
            if (s.Buscarhijo(codigo))
            {
                if (s.Eliminar(codigo))
                {
                    Label.Text = "Eliminado correctamente";
                }
            }
            else
            {
                Label.Text = "Tiene una referencia no puede eliminar";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Sistema.aspx");

        }
       
        //internal static object Lista(string p1, string p2)
      //  {
           // throw new NotImplementedException();
        //}//*
    }
    }
