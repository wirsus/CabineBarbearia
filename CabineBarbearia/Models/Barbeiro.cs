using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CabineBarbearia.Models
{
    public class Barbeiro
    {
        [Key]
        [Display(Name = "Código Barbeiro")]
        [Column("id_barbeiro")]
        public int IDBarbeiro { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe o nome do barbeiro!")]
        [StringLength(100, ErrorMessage = "O nome deve conter no máximo {1} caracteres!"), MinLength(5, ErrorMessage = "O nome deve conter no mínimo {1} caracteres!")]
        [Column("nm_usuario")]
        public String Nome { get; set; }

        [Display(Name = "Apelido")]
        [StringLength(100, ErrorMessage = "O apelido deve conter no máximo {1} caracteres!"), MinLength(2, ErrorMessage = "O apelido deve conter no mínimo {1} caracteres!")]
        [Column("nm_apelido")]
        public String Apelido { get; set; }

        [Display(Name = "Celular")]
        [Column("nr_celular")]
        public String Celular { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido!")]
        [Column("dc_email")]
        public String Email { get; set; }

        [Display(Name = "Data de Admissão")]
        [DisplayFormat(DataFormatString = ("{0:d}"), ApplyFormatInEditMode = true)]
        [Column("dt_admissao")]
        public DateTime Admissao { get; set; }

        [Display(Name = "Status do Barbeiro")]
        [Column("id_status")]
        public bool Status { get; set; }
    }
}