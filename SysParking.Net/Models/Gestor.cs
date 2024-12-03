﻿using Microsoft.AspNetCore.Identity;

namespace SysParking.Net.Models
{
    public class Gestor : IdentityUser
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        //public string Senha { get; set; }
    }
}
