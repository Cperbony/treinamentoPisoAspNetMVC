using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestaoComercial.website.Models
{
    [Table("cliente")]
    public partial class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Cliente")]
        public string NomeCompletoRazaoSocial { get; set; }

        [StringLength(255)]
        [Display(Name = "Nome Fantasia")]
        public string ApelidoNomeFantasia { get; set; }

        [StringLength(15)]
        [Display(Name = "CPF / CNPJ")]
        public string CPFCNPJ { get; set; }



    }
}