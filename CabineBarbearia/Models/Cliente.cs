using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CabineBarbearia.Models
{
    public class Cliente
    {
        [Key]
        [Display(Name = "Código Cliente")]
        public int id_cliente { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe o nome do cliente!")]
        [StringLength(100, ErrorMessage = "O nome deve conter no máximo {1} caracteres!"), MinLength(5, ErrorMessage = "O nome deve conter no mínimo {1} caracteres!")]
        public String nm_cliente { get; set; }

        [Display(Name = "Apelido")]
        [StringLength(100, ErrorMessage = "O apelido deve conter no máximo {1} caracteres!"), MinLength(2, ErrorMessage ="O apelido deve conter no mínimo {1} caracteres!")]
        public String nm_apelido { get; set; }

        [Display(Name = "Celular")]
        public String nr_celular { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido!")]
        public String dc_email { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DisplayFormat(DataFormatString = ("{0:d}"), ApplyFormatInEditMode = true)]
        public DateTime dt_cadastro { get; set; }

        [Display(Name = "Status do Cliente")]
        public bool id_status { get; set; }

    }
}