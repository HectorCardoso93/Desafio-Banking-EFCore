using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnicoBanking.Modelos
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Key]
        public long Cpf { get; set; }
        public string Nome { get; set; }
    }
}
