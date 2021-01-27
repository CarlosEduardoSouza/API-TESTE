using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Compugraf.API.Models
{
    [Table("Pessoas")]
    public class Pessoa
    {
        [Key]
        public int PessoaId { get; set; }

        [Required(ErrorMessage ="Campo {0} preenchimento obrigatorio")]
        [MaxLength(30)]
        public string Nome { get; set; }

    
        [Required(ErrorMessage = "Campo {0} preenchimento obrigatorio")]
        [MaxLength(30)]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Campo {0} preenchimento obrigatorio")]
        [MaxLength(30)]
        public string Nacionalidade { get; set; }

        [Required(ErrorMessage = "Campo {0} preenchimento obrigatorio")]
        [MaxLength(9)]
        public string CEP { get; set; }

        
        [Required(ErrorMessage = "Campo {0} preenchimento obrigatorio")]
        [MaxLength(11)]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Campo {0} preenchimento obrigatorio")]
        [MaxLength(30)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Campo {0} preenchimento obrigatorio")]
        [MaxLength(50)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo {0} preenchimento obrigatorio")]
        [MaxLength(100)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo {0} preenchimento obrigatorio")]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo {0} preenchimento obrigatorio")]
        [MaxLength(16)]
        public string Telefone { get; set; }
    }
}
