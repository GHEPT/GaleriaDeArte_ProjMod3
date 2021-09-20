using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GaleriaDeArte.Models
{
    public class Lance
    {
        [Display(Name = "#")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name ="Nome completo")]
        public string Nome { get; set; }

        [Display(Name = "CPF (XXX.XXX.XXX-XX)")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(14)]
        public string CPF { get; set; }

        [Display(Name = "Lance (em milhões de R$)")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public double Proposta { get; set; }

        [Required(ErrorMessage = "Lance deve possuir uma obra de arte")]
        [Display(Name = "Obra")]
        public int? ObraId { get; set; }

        public Obra Obra { get; set; }

        public string UserId { get; set; }

        public IdentityUser User { get; set; }
    }
}
