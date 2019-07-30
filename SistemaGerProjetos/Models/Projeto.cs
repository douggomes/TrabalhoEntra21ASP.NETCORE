using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGerProjetos.Models
{
    public class Projeto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório!", AllowEmptyStrings = false)]
        [MaxLength(70, ErrorMessage = "O campo 'Nome' deve conter no máximo 70 caracteres!")]
        public string NomeProjeto { get; set; }

        [ForeignKey("IdCliente")]
        public string NomeClienteProjeto { get; set; }
        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = "A data de criação deve ser informada!")]
        [DataType(DataType.Date, ErrorMessage = "Uma data valida deve ser informada no seguinte formato dd/mm/aaaa.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataCriacao { get; set; }

        [Required(ErrorMessage = "A data de finalização de ser informada!")]
        [DataType(DataType.Date, ErrorMessage = "Uma data valida deve ser informada no seguinte formato dd/mm/aaaa.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataFinalizacao { get; set; }
    }
}
