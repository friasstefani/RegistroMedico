using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace Bll
{
    public class Paciente
    {
        
        public int Idpaciente { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }
        public String Celular { get; set; }
        public String Direccion { get; set; }
        public String cedula { get; set; }
        public String sexo { get; set; }
        public String ocupacion { get; set; }
        public DateTime fechanacimiento { get; set; }
        public DateTime fechaingreso { get; set; }

        Conexion conectar = new Conexion();

        public Paciente(int Idpaciente, String Nombre,string Apellido,String Telefono, String Celular, String Direcion, String Email)
        {

            this.Idpaciente = Idpaciente;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Telefono = Telefono;
            this.Celular = Celular;
            this.Direccion = Direcion;
            this.cedula = cedula;
            this.sexo = sexo;
            this.ocupacion = ocupacion;
            this.fechanacimiento = fechanacimiento;
            this.fechaingreso = fechaingreso;


        }

        public Paciente()
        {
            // TODO: Complete member initialization
        }
        public bool Insertar()
        {
            return conectar.EjecutarDB("Insert Into Datos(Nombre,apellido,Telefono,Celular,Direccion,cedula,sexo,ocupacion,fechanacimiento, fechaingreso ) Values ('" +
                Nombre + "','" + Apellido + "','" + Telefono + "','" + Celular + "','" + Direccion + "','" + cedula + "','" + sexo + "','" + ocupacion + "','" + fechanacimiento + "','" + fechaingreso + "')");
        }

        public bool Modificar(int Idpaciente)
        {
            return conectar.EjecutarDB(" update Datos set Nombre ='" + Nombre + "',Apellido ='" + Apellido + "',Telefono ='" + Telefono + "',Celular ='" + Celular + "',Direccion ='" + Direccion + "',cedula ='" + cedula + "',sexo ='" + sexo + "',ocupacion ='" + ocupacion + "',fechanacimiento ='" + fechanacimiento + "',fechaingreso ='" + fechaingreso + "' where Idpaciente = '" + Idpaciente + "' ");
        }

        public bool Eliminar(int Idpaciente)
        {

            return conectar.EjecutarDB("Delete from Datos where Idpaciente='" + Idpaciente + "' ");
        }

        public bool Buscar(int Idpaciente)
        {
            bool mensaje = false;


            DataTable dt;

            dt = conectar.BuscarDb("select * from Datos where Idpaciente = " + Idpaciente);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;

                this.Idpaciente = (int)dt.Rows[0]["Idpaciente"];
                this.Nombre = (String)dt.Rows[0]["Nombre"];
                this.Apellido = (String)dt.Rows[0]["Apellido"];
                this.Telefono = (String)dt.Rows[0]["Telefono"];
                this.Celular = (String)dt.Rows[0]["Celular"];
                this.Direccion = (String)dt.Rows[0]["Direccion"];
                this.cedula = (String)dt.Rows[0]["cedula"];
                this.sexo = (String)dt.Rows[0]["sexo"];
                this.ocupacion = (String)dt.Rows[0]["ocupacion"];
                this.fechanacimiento = (DateTime)dt.Rows[0]["fechanacimiento"];
                this.fechaingreso = (DateTime)dt.Rows[0]["fechaingreso"];


            }

            return mensaje;
        }
        public static DataTable Lista(String Campos, String FiltroWhere)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + " From Datos Where " + FiltroWhere);
        }
        

    }
}
