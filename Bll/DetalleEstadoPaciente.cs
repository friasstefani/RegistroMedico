using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace Bll
{
    public class DetalleEstadoPaciente
    {


        public int IdDetalle { get; set; }
        public int IdEstado { get; set; }
        public int IdSistema { get; set; }
        public String SituacionPaciente { get; set; }


        Conexion conectar = new Conexion();

        public DetalleEstadoPaciente(int IdEstado, int IdSistema, string SituacionPaciente)
        {

            this.IdEstado = IdEstado;
            this.IdSistema = IdSistema;
            this.SituacionPaciente = SituacionPaciente;


        }

        public DetalleEstadoPaciente()
        {
            // TODO: Complete member initialization
        }
        public bool Insertar()
        {
            return conectar.EjecutarDB("Insert Into DetalleEstadoPaciente(IdEstado,IdSistema,SituacionPaciente ) Values ('" +IdEstado + "','" + IdSistema + "','" + SituacionPaciente + "')");
        }

        public bool Modificar(int IdDetalle)
        {
            return conectar.EjecutarDB(" update DetalleEstadoPaciente set IdEstado ='" + IdEstado + "',IdEstado ='" + IdEstado + "',IdSistema ='" + IdSistema + "',SituacionPaciente='" + SituacionPaciente + "' where IdDetalle = '" + IdDetalle + "' ");
        }

        public bool Eliminar(int IdDetalle)
        {

            return conectar.EjecutarDB("Delete from DetalleEstadoPaciente where IdDetalle='" + IdDetalle + "' ");
        }

        public bool Buscar(int IdDetalle)
        {
            bool mensaje = false;


            DataTable dt;

            dt = conectar.BuscarDb("select * from DetalleEstadoPaciente where IdDetalle = " + IdDetalle);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;

                this.IdEstado = (int)dt.Rows[0]["IdEstado"];
                this.IdSistema = (int)dt.Rows[0]["IdSistema"];
                this.SituacionPaciente = (String)dt.Rows[0]["SituacionPaciente"];
            }

            return mensaje;
        }
        public static DataTable Lista(String Campos, String FiltroWhere)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + " From DetalleEstadoPaciente Where " + FiltroWhere);
        }
        public static DataTable BuscarCampos(string campos, string filtro)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + campos + " From " + filtro);
        }
    }
}