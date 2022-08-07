namespace PoupaDevAPI.Exceptions
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() : base("Saldo insuficiente!") { }
    }
}