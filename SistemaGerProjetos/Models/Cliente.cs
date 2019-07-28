using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaGerProjetos.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("IdCidade")]
        public virtual Cidade Cidade { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório!", AllowEmptyStrings = false)]
        [MaxLength(70, ErrorMessage = "O campo 'Nome' deve conter no máximo 70 caracteres!")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo 'CPF' é obrigatório!")]
        [StringLength(14, MinimumLength = 11, ErrorMessage =
            "O CPF deve ter no mínimo 11 e no máximo 14 caracteres (Quando incluido os caracteres especiais).")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "A data de Nascimento de ser informada!")]
        [DataType(DataType.Date, ErrorMessage ="Uma data valida de ser informada no seguinte formato dd/mm/aaaa.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo 'Numero' deve ser informado!")]
        [Range(1,999999, ErrorMessage = "O digito 0 não é aceito neste campo!")]
        public int Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo 'Logradouro' deve ser informado!", AllowEmptyStrings = false)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo 'CEP' deve ser informado!")]
        [StringLength(9, MinimumLength = 8, ErrorMessage =
            "O CEP deve ter no mínimo 8 e no máximo 9 caracteres (Quando incluido o caracter especiail - ).")]
        public string Cep { get; set; }
    }
}
