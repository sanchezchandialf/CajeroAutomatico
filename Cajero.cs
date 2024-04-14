using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    public class Cajero
    {
        public string adress { get; set; }
        public int NroCajero{get;set;}

        public List <CuentaBancaria> cuentasCreadasCajeros=new List <CuentaBancaria> ();
        public Cajero() { }
        public Cajero(string adress, int nroCajero)
        {
            this.adress = adress;
            NroCajero = nroCajero;
        }

        public void comprobacion() { }
        public void CrearCuenta(CuentaBancaria usuario)
        {
            Console.WriteLine("ingrese su dni");
            string dni1=Console.ReadLine();
            Console.WriteLine("ingrese su nombre");
            String nombre= Console.ReadLine();
            Console.WriteLine("ingrese su direccion");
            String address= Console.ReadLine();
            Console.WriteLine("ingrese 1 si es jubilado o 2 si esta en actividad");
            Int32.TryParse(Console.ReadLine(), out int act);
            Usuario nuevousuario= new Usuario(dni1,nombre,address,act);
            List<Operaciones> nuevalistadeoperaciones = new List <Operaciones>();
            CuentaBancaria cuentanueva = new CuentaBancaria();
            int nuevo = cuentanueva.nroCuenta + 1;
            
            CuentaBancaria cuentabancaria = new CuentaBancaria(nuevo, 0, DateTime.Now,nuevalistadeoperaciones, nuevousuario);
            
            Console.WriteLine("CUENTA CREADA CON EXITO");
            Console.WriteLine(cuentabancaria.ToString());
            cuentasCreadasCajeros.Add(cuentabancaria);
            
    }
        public void Deposito(double valor,CuentaBancaria cuenta )
        {
             cuenta.SaldoActual +=valor;
        }
        public void Extraer(double valor, CuentaBancaria cuenta)
        {
            cuenta.SaldoActual -= valor;
        }

        public void Preacordada(string orden,double valor,CuentaBancaria cuenta)
        {
            cuenta.SaldoActual -= valor;
        }
        
    }
}
