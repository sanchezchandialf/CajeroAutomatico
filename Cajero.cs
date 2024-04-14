using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    internal class Cajero
    {
        public string adress { get; set; }
        public int NroCajero{get;set;}

        public Cajero() { }
        public Cajero(string adress, int nroCajero)
        {
            this.adress = adress;
            NroCajero = nroCajero;
        }
        public void CrearCuenta(CuentaBancaria usuario)
        {
            Console.WriteLine("ingrese su dni");
            Int32.TryParse(Console.ReadLine(), out int dni);
            Console.WriteLine("ingrese su nombre");
            String nombre= Console.ReadLine();
            Console.WriteLine("ingrese su direccion");
            String address= Console.ReadLine();
            Console.WriteLine("ingrese 1 si es jubilado o 2 si esta en actividad");
            Int32.TryParse(Console.ReadLine(), out int adre);


        }
    }
}
