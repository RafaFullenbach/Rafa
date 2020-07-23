using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroClientes.Models
{

    [Table("CLIENTES")]
    public class Cliente
    {
        public Cliente()
            {
                dt_cadastro = DateTime.Now;
                IsDeleted = '0';
            }

        [Key]
        [Column("CD_CLIENTE")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cd_cliente { get; set; }

        [Column("NM_CLIENTE")]
        [Required(ErrorMessage = "Nome Obrigatório!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome deve ter, no mínimo, 3 e, no máximo, 50 caracteres")]
        [Display(Name = "Nome:")]
        public String nm_cliente { get; set; }

        [Column("TIPO")]
        [Display(Name = "Tipo:")]
        public String tipo { get; set; }

        [Column("NR_DOCUMENTO")]
        [Required(ErrorMessage = "Documento Obrigatório!")]
        [StringLength(17, MinimumLength = 14, ErrorMessage = "O documento deve ter, no mínimo, 14 e, no máximo, 17 caracteres")]
        [Display(Name = "Documento:")]
        public String nr_documento { get; set; }

        [Column("DT_CADASTRO")]
        [Display(Name = "Data:")]
        public DateTime dt_cadastro { get; set; }

        [Column("NR_TELEFONE")]
        [Required(ErrorMessage = "Telefone Obrigatório!")]
        [StringLength(15, MinimumLength = 14, ErrorMessage = "O telefone deve ter, no mínimo, 14 e, no máximo, 15 caracteres")]
        [Display(Name = "Telefone:")]
        public String nr_telefone { get; set; }

        [Column("ISDELETED")]
        public Char IsDeleted { get; set; }
    }
}
