using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaGerProjetos.Models
{
    public class Cidade
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório!", AllowEmptyStrings = false)]
        [MaxLength(70, ErrorMessage = "O campo 'Nome' deve conter no máximo 70 caracteres!")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        public string Nome { get; set; }

        [ForeignKey("IdEstado")]
        public string NomeEstado { get; set; }
        public Estado Estado{ get; set; }

        [Required(ErrorMessage = "O campo 'Numero de habitantes' é obrigatório!")]
        [Range(1,99999999, ErrorMessage = "Informe um número maior que 0.")]
        public int NumeroHabitantes { get; set; }
    }
}
