using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace Bll
{
    public class EstadoPaciente
    {

        public int IdEstado { get; set; }
        public int IdPaciente { get; set; }
        public DateTime fecha { get; set; }
        public List<DetalleEstadoPaciente> DetalledEstadoPaciente = new List<DetalleEstadoPaciente>();


        Conexion conectar = new Conexion();

        public EstadoPaciente(int IdEstado, int Idpaciente, DateTime fecha)
        {

            this.IdEstado = IdEstado;
            this.IdPaciente = IdPaciente;
            this.fecha = fecha;



        }

        public EstadoPaciente()
        {
            // TODO: Complete member initialization
        }
        public bool Insertar()
        {
            int a = 0;
            int.TryParse(conectar.GetDbValue("Insert Into EstadoPaciente( IdPaciente,fecha ) Values ('" + IdPaciente + "','" + fecha.ToString("MM/dd/yyyy") + "'); Select @@Identity ").ToString(), out a);

            int IdEstado = a;

            if (IdEstado > 0)
            {
                foreach (DetalleEstadoPaciente item in DetalledEstadoPaciente)
                {
                    item.IdEstado = IdEstado;
                    item.Insertar();
                }
            }

            return IdEstado > 0;
        }

        public bool Modificar(int IdEstado)
        {
            return conectar.EjecutarDB(" update EstadoPaciente set IdPaciente ='" + IdPaciente + "',fecha ='" + fecha.ToString("MM/dd/yyyy") + "' where IdEstado = '" + IdEstado + "' ");
        }

        public bool Eliminar(int IdEstado)
        {
            conectar.EjecutarDB("delete from DetalleEstadoPaciente where IdEstado = '" + IdEstado + "' ");
            return conectar.EjecutarDB("Delete from EstadoPaciente where IdEstado ='" + IdEstado + "' ");
        }

        public bool Buscar(int IdEstado)
        {
            bool mensaje = false;


            DataTable dt;

            dt = conectar.BuscarDb("select * from EstadoPaciente where IdEstado = " + IdEstado);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;

                this.IdEstado = (int)dt.Rows[0]["IdEstado"];
                this.IdPaciente = (int)dt.Rows[0]["IdPaciente"];
                this.fecha = (DateTime)dt.Rows[0]["fecha"];
            }

            dt = conectar.BuscarDb("Select * from DetalleEstadoPaciente where IdEstado = " + IdEstado);

            foreach (DataRow datos in dt.Rows)
            {
                AgregarDetalledEstadoPaciente(this.IdEstado , int.Parse(datos["IdSistema"].ToString()), datos["SituacionPaciente"].ToString());
            }


            return mensaje;
        }

        public static DataTable Lista(String Campos, String FiltroWhere)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + " From EstadoPaciente Where " + FiltroWhere);
        }

        public void AgregarDetalledEstadoPaciente(int IdEstado, int IdSistema, string SituacionPaciente)
        {
            DetalledEstadoPaciente.Add(new DetalleEstadoPaciente(IdEstado, IdSistema, SituacionPaciente));
        }

    }
}