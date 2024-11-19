using System.ComponentModel;

namespace SysParking.Net.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public Carro Carro { get; set; }
        public int CarroId { get; set; }
        public Estacionamento Estacionamento { get; set; }
        public int EstacionamentoId { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime HoraSaida { get; set; }
        public TipoPagamento Pagamento { get; set; }


    }

    public enum TipoPagamento
    {
        [Description("Dinheiro")]
        DINHEIRO = 0,

        [Description("Cartão de Crédito")]
        CARTAO_CREDITO = 1,

        [Description("Cartão de Débito")]
        CARTAO_DEBITO = 2,

        [Description("Pix")]
        PIX = 3
    }

}
