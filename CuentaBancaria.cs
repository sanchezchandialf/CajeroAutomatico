namespace CajeroAutomatico
{
    public class CuentaBancaria
    {
        public int ultimacuenta = 0;
        public int nroCuenta {  get; set; }
        public double SaldoActual { get; set; }
        public DateTime fecha { get; set; }
        public List<Operaciones> Loperaciones { get; set; }
        public Usuario usuario { get; set; }

         
        public CuentaBancaria() { }

        public CuentaBancaria(Usuario usuario)
        {
            this.nroCuenta = ++ultimacuenta;
            SaldoActual = 0;
            this.fecha = DateTime.Now;
            this.Loperaciones=new List<Operaciones> ();
            this.usuario = usuario;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public void deposito(double monto)
        {
           SaldoActual = SaldoActual+monto;
        }
        public void salvar(double monto) { SaldoActual = SaldoActual - monto; }
       
    }
}
  