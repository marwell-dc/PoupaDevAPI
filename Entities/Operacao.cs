using PoupaDevAPI.Enums;

namespace PoupaDevAPI.Entities
{
    public class Operacao
    {
        public int Id { get; private set; }
        public decimal Valor { get; private set; }
        public TipoOperacao Tipo { get; private set; }
        public DateTime DataOperacao { get; set; }

        public Operacao(decimal valor, TipoOperacao tipo)
        {
            Id = new Random().Next(1, 1000);
            Valor = valor;
            Tipo = tipo;

            DataOperacao = DateTime.Now;
        }
    }
}
