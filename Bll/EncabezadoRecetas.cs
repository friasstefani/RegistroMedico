using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace Bll
{
    public class EncabezadoRecetas
    {

        public int IdReceta { get; set; }
        public int IdPaciente { get; set; }
        public DateTime fecha { get; set; }
        public List<DetalleRecetas> DetalleRecetas = new List<DetalleRecetas>();


        Conexion conectar = new Conexion();

        public EncabezadoRecetas(int IdReceta, int Idpaciente, DateTime fecha)
        {
            this.IdReceta = IdReceta;
            this.IdPaciente = IdPaciente;
            this.fecha = fecha;
            DetalleRecetas = new List<DetalleRecetas>();
        }

        public EncabezadoRecetas()
        {
            DetalleRecetas = new List<DetalleRecetas>();
            // TODO: Complete member initialization
        }
        public bool Insertar()
        {
            string comando = " Select getdate() ";

            int IdReceta = (int)conectar.GetDbValue("Insert Into EncabezadoRecetas(IdPaciente,fecha ) Values ('" + IdPaciente + "','" + fecha.ToString("MM/dd/yyyy") + "'); Select @@Identity ");

            if (IdReceta > 0)
            {
                foreach (DetalleRecetas item in DetalleRecetas)
                {
                    comando += " Insert into DetalleRecetas (IdReceta,IdMedicamento,Descripcion,Cantidad) Values(" + IdReceta + "," + item.IdMedicamento + "," + item.Descripcion + "," + item.Cantidad + ");";
                }

                conectar.EjecutarDB(comando);
            }

            return IdReceta > 0;
        }

        public bool Modificar(int IdReceta)
        {
            string comando;
            comando = "Update EncabezadoRecetas Set IdPaciente = " + IdPaciente + "," + " Fecha = '" + fecha + "' Where IdReceta =" + IdReceta + " ;";

            conectar.EjecutarDB("Delete From DetalleRecetas Where IdReceta = " + IdReceta);

            foreach (DetalleRecetas item in DetalleRecetas)
            {
                comando += " Insert into DetalleRecetas (IdReceta,IdMedicamento,Descripcion,Cantidad) Values(" + IdReceta + "," + item.IdMedicamento + "," + item.Descripcion + "," + item.Cantidad + ");";
            }

            return conectar.EjecutarDB(comando);
        }

        public bool Eliminar(int IdReceta)
        {
            conectar.EjecutarDB("delete from DetalleRecetas where IdReceta = '" + IdReceta + "' ");
            return conectar.EjecutarDB("Delete from EncabezadoRecetas where IdReceta ='" + IdReceta + "' ");
        }

        public bool Buscar(int IdReceta)
        {
            bool mensaje = false;
            DataTable dt;

            dt = conectar.BuscarDb("select * from EncabezadoRecetas where IdReceta = " + IdReceta);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;

                this.IdReceta = (int)dt.Rows[0]["IdReceta"];
                this.IdPaciente = (int)dt.Rows[0]["IdPaciente"];
                this.fecha = (DateTime)dt.Rows[0]["fecha"];
            }

            dt = conectar.BuscarDb("Select * from DetalleRecetas where IdReceta = " + IdReceta);

            foreach (DataRow datos in dt.Rows)
            {
                AgregarDetalleRecetas(this.IdReceta, int.Parse(datos["IdReceta"].ToString()), int.Parse(datos["IdMedicamento"].ToString()), datos["IdPaciente"].ToString(), float.Parse(datos["IdPaciente"].ToString()));
            }

            return mensaje;
        }

        public static DataTable Lista(String Campos, String FiltroWhere)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + " From EncabezadoRecetas Where " + FiltroWhere);
        }

        public void AgregarDetalleRecetas(int IdDetalle, int IdReceta, int IdMedicamento, string Descripcion, float Cantidad)
        {
            DetalleRecetas.Add(new DetalleRecetas(IdDetalle, IdReceta, IdMedicamento, Descripcion, Cantidad));
        }

    }
}