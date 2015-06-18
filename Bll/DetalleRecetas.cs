using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class DetalleRecetas
    {
        public int IdDetalle;
        public int IdReceta;
        public int IdMedicamento;
        public string Descripcion;
        public double Cantidad;

        public DetalleRecetas(int idDetalle, int IdReceta, int IdMedicamento,string Descripcion, double Cantidad)
        {
            this.IdDetalle = idDetalle;
            this.IdReceta = IdReceta;
            this.IdMedicamento = IdMedicamento;
            this.Descripcion = Descripcion;
            this.Cantidad = Cantidad;
        }
    }
}
