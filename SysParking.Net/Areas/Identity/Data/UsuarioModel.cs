using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SysParking.Net.Areas.Identity.Data;

// Add profile data for application users by adding properties to the UsuarioModel class
public class UsuarioModel : IdentityUser
{
    [MaxLength(50, ErrorMessage = "O tamanho máximo do campo {0} e de {1} caracteres")]
    [Required]
    public string Nome { get; set; }

    [MaxLength(15, ErrorMessage = "O tamanho máximo do campo {0} e de {1} caracteres")]
    [Required]
    public string Telefone { get; set; }
}


