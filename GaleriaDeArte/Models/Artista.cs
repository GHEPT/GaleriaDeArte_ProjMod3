using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GaleriaDeArte.Models
{
    public class Artista
    {
        [Display(Name = "#")]
        public int Id { get; set; }

        [Display(Name = "Foto")]
        public string Imagem { get; set; }

        [Required(ErrorMessage = "Informe o nome do artista")]
        [Display(Name = "Nome do Artista")]
        public string Nome { get; set; }

        [Display(Name = "Sobre ele")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe o patrimônio do artista")]
        [Display(Name ="Patrimônio (em R$)")]
        public double? Patrimonio { get; set; }

        [Required(ErrorMessage = "Informe a data de nascimento")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime? Data { get; set; }

    }
}