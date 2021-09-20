using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GaleriaDeArte.Models
{
    public class Obra
    {
        [Display(Name = "#")]
        public int Id { get; set; }

        [Display(Name = "Imagem")]
        public string Imagem { get; set; }

        [Required(ErrorMessage = "Informe um título para a obra")]
        [Display(Name = "Título")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o autor da obra")]
        [Display(Name = "Autor")]
        public string Autor { get; set; }

        [Display(Name = "Sobre")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Preço da obra é obrigatório")]
        [Display(Name ="Valor (em milhões de R$)")]
        public double? Preco { get; set; }

        [Required(ErrorMessage = "Informe a data da criação da obra")]
        [Display(Name = "Data da Obra")]
        [DataType(DataType.Date)]
        public DateTime? Data { get; set; }

        public List<Lance> Lances { get; set; }
    }
}