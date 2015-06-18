using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace Bll
{
  public class Usuario
    {
        public int IdUsuario { get; set; }
        public String NombreUsuario { get; set; }
        public String Contraseña{ get; set; }
        public int Nivel { get; set; }
      

        Conexion conectar = new Conexion();

        public Usuario(int IdUsuario, String Nombre, string Contraseña,int Nivel)
        {

            this.IdUsuario = IdUsuario;
            this.NombreUsuario = NombreUsuario;
            this.Contraseña = Contraseña;
            this.Nivel = Nivel;
    }


        public Usuario()
        {
            // TODO: Complete member initialization
        }
        public bool Insertar()
        {
            return conectar.EjecutarDB("Insert Into Usuario (NombreUsuario,Contraseña, Nivel ) Values ('" + NombreUsuario + "','" + Contraseña + "','" + Nivel + "')");
        }

        public bool Modificar(int IdUsuario)
        {
            return conectar.EjecutarDB(" update  Usuario  set NombreUsuario ='" + NombreUsuario + "',Contraseña ='" + Contraseña+ "',Nivel ='" + Nivel + "'where IdUsuario = '" + IdUsuario + "' ");
        }

        public bool Eliminar(int IdUsuario)
        {

            return conectar.EjecutarDB("Delete from  Usuario  where IdUsuario  ='" + IdUsuario + "',Contraseña ='" + Contraseña + "',Nivel ='" + Nivel + "' ");
        }

        public bool Buscar(int IdUsuario)
        {
            bool mensaje = false;


            DataTable dt;

            dt = conectar.BuscarDb("select * from Usuario where IdUsuario  = " + IdUsuario);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;

                this.IdUsuario = (int)dt.Rows[0]["IdUsuario "];
                this.NombreUsuario = (String)dt.Rows[0]["NombreUsuario "];
                this.Contraseña = (String)dt.Rows[0]["Contraseña "];
                this.Nivel = (int)dt.Rows[0]["Nivel"];
                }

            return mensaje;
        }
        public static DataTable Lista(String Campos, String FiltroWhere)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + " From Usuario Where " + FiltroWhere);
        }

        public static bool Logon(string NombreUsuario, string Contraseña)
        {
            Conexion ConexionDB = new Conexion();
            bool Msj=false;
            DataTable dt;
            dt = ConexionDB.BuscarDb("select * from Usuario Where NombreUsuario='" + NombreUsuario + "' and Contraseña ='" + Contraseña + "'");
            if (dt.Rows.Count > 0)
                Msj = true;
            return Msj;
        }

    }
}



   
