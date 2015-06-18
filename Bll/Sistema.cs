using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace Bll
{
   public  class Sistema
    {
        public int IdSistema { get; set; }
        public String Nombre { get; set; }
      

        Conexion conectar = new Conexion();
       
        public Sistema(int IdSistema, String Nombre)
        {

            this.IdSistema = IdSistema;
            this.Nombre = Nombre;
           
    }

       
        public Sistema()
        {
            // TODO: Complete member initialization
        }
        public bool Insertar()
        {
            return conectar.EjecutarDB("Insert Into Sistema (Nombre ) Values ('" + Nombre + "')");
        }

        public bool Modificar(int IdSistema)
        {
            return conectar.EjecutarDB(" update Sistema set Nombre ='" + Nombre + "' where IdSistema = '" + IdSistema + "' ");
        }

        public bool Eliminar(int IdSistema)
        {

            return conectar.EjecutarDB("Delete from Sistema where IdSistema =" + IdSistema + " ");
        }

        public bool Buscar(int IdSistema)
        {
            bool mensaje = false;


            DataTable dt;

            dt = conectar.BuscarDb("select * from Sistema where IdSistema = " + IdSistema);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;

                this.IdSistema = (int)dt.Rows[0]["IdSistema"];
                this.Nombre = (String)dt.Rows[0]["Nombre"];
              
                }

            return mensaje;
        }
        public bool Buscarhijo(int IdSistema)
        {
            bool Msj = true;
            DataTable dt = new DataTable();
            dt = conectar.BuscarDb("select * from DetalleEstadoPaciente where IdSistema="+IdSistema);
            if (dt.Rows.Count > 0)
                Msj = false;
            return Msj;
        }

        public static DataTable Lista(String Campos, String FiltroWhere)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + " From Sistema Where " + FiltroWhere);
        }
        

    }
}



   

