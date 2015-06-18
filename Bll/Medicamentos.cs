using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace Bll
{
    public class Medicamentos
    {
        public int IdMedicamento { get; set; }
        public String Nombre { get; set; }


        Conexion conectar = new Conexion();

        public Medicamentos(int IdMedicamento, String Nombre)
        {

            this.IdMedicamento = IdMedicamento;
            this.Nombre = Nombre;

        }


        public Medicamentos()
        {
            // TODO: Complete member initialization
        }
        public bool Insertar()
        {
            return conectar.EjecutarDB("Insert Into Medicamentos (Nombre ) Values ('" + Nombre + "')");
        }

        public bool Modificar(int IdMedicamento)
        {
            return conectar.EjecutarDB(" update Medicamentos set Nombre ='" + Nombre + "' where IdMedicamento = '" + IdMedicamento + "' ");
        }

        public bool Eliminar(int IdMedicamento)
        {

            return conectar.EjecutarDB("Delete from Medicamentos where IdMedicamento =" + IdMedicamento + " ");
        }

        public bool Buscar(int IdMedicamento)
        {
            bool mensaje = false;


            DataTable dt;

            dt = conectar.BuscarDb("select * from Medicamentos where IdMedicamento = " + IdMedicamento);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;

                this.IdMedicamento = (int)dt.Rows[0]["IdMedicamento"];
                this.Nombre = (String)dt.Rows[0]["Nombre"];

            }

            return mensaje;
        } 

        public static DataTable Lista(String Campos, String FiltroWhere)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + " From Medicamentos Where " + FiltroWhere);
        }


    }
}





