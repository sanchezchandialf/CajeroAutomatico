using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
     public class Operaciones
    {
        public DateTime Fecha;
        public int cajero;
        public string[] tipoOperracion = { "deposito", "extraccion", "extraccionPreacor", "dado" };
        public double monto;
        public Operaciones() { }

        public Operaciones(DateTime fecha, int cajero, string[] tipoOperracion, double monto)
        {
            Fecha = fecha;
            this.cajero = cajero;
            this.tipoOperracion = tipoOperracion;
            this.monto = monto;
        }
    }
}
