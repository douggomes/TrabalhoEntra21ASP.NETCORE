using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace SistemaGerProjetos.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("IdUsuarioResponsavel")]
        public string NomeUsuarioResponsavel {get; set;}
        public Usuario Usuario {get; set;}

        [ForeignKey("IdProjeto")]
        public string NomeProjetoTarefa { get; set; }
        public Projeto Projeto { get; set; }

        [ForeignKey("IdCategoria")]
        public string NomeCategoriaTarefa { get; set; }
        public Categoria Categoria { get; set; }

        public string TituloTarefa { get; set; }

        public string DescricaoTarefa { get; set; }

        public DateTime DuracaoTarefa { get; set; }
    }
}
