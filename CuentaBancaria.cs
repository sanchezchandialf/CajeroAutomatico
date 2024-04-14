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

        public CuentaBancaria(int nroCuenta, double saldoActual, DateTime fecha,List<Operaciones>loperaciones ,Usuario usuario)
        {
            this.nroCuenta = ++ultimacuenta;
            SaldoActual = saldoActual;
            this.fecha = fecha;
            this.Loperaciones = loperaciones;
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
  