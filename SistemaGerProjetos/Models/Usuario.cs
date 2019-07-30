using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGerProjetos.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O campo 'Nome' deve conter no máximo 50 caracteres!")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "O campo 'Login' é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O campo 'Login' deve conter no máximo 50 caracteres!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O campo 'Senha' é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O campo 'Senha' deve conter no máximo 50 caracteres!")]
        public string Senha { get; set; }

        public string Role { get; set; }
    }
}
