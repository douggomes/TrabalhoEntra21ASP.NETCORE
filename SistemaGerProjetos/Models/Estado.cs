using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaGerProjetos.Models
{
    public class Estado
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório!")]
        [StringLength(70, ErrorMessage = "O campo 'Nome' deve conter até 70 caracteres!")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        public string NomeEstado { get; set; }

        [Required(ErrorMessage = "O campo 'Sigla' é obrigatório!")]
        [StringLength(2, ErrorMessage = "O campo 'Sigla' deve conter 2 caracteres!")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos na sigla.")]
        public string SiglaEstado { get; set; }
    }
}
