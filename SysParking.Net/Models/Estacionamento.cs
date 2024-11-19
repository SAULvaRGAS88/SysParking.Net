namespace SysParking.Net.Models
{
    public class Estacionamento
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public int NumeroVagasDisponiveis { get; set; }
        public Gestor Gestor { get; set; }
        public int GestorId { get; set; }
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public List<Nota> Notas { get; set; } = new List<Nota>();

    }
}
