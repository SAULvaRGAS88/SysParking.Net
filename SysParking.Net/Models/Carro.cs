﻿namespace SysParking.Net.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public List<Nota> Notas { get; set; } = new List<Nota>();
    }
}
