﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CabineBarbearia.Models
{
    public class Cliente
    {
        [Key]
        [Display(Name = "Código Cliente")]
        [Column("id_cliente")]
        public int IDCliente { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe o nome do cliente!")]
        [StringLength(100, ErrorMessage = "O nome deve conter no máximo {1} caracteres!"), MinLength(5, ErrorMessage = "O nome deve conter no mínimo {1} caracteres!")]
        [Column("nm_cliente")]
        public String Nome{ get; set; }

        [Display(Name = "Apelido")]
        [StringLength(100, ErrorMessage = "O apelido deve conter no máximo {1} caracteres!"), MinLength(2, ErrorMessage ="O apelido deve conter no mínimo {1} caracteres!")]
        [Column("nm_apelido")]
        public String Apelido { get; set; }

        [Display(Name = "Celular")]
        [Column("nr_celular")]
        public String Celular { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido!")]
        [Column("dc_email")]
        public String Email { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DisplayFormat(DataFormatString = ("{0:d}"), ApplyFormatInEditMode = true)]
        [Column("dt_cadastro")]
        public DateTime Cadastro { get; set; }

        [Display(Name = "Status do Cliente")]
        [Column("id_status")]
        public bool Status { get; set; }

    }
}