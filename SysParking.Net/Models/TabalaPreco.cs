namespace SysParking.Net.Models
{
    public class TabalaPreco
    {
        public int Id { get; set; }
        public double Preco15Min { get; set; }
        public double Preco30Min { get; set; }
        public double Preco1Hora { get; set; }
        public double PrecoDiaria { get; set; }
        public double PrecoMensal { get; set; }
        public int EstacionamentoId { get; set; }
        public Estacionamento Estacionamento { get; set;}
    }
}
