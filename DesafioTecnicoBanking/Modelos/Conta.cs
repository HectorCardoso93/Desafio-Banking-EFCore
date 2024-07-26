using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DesafioTecnicoBanking.Modelos
{
    [Table("Conta")]
    public class Conta
    {
        public int NumeroConta { get; internal set; }
        public int Agencia { get ; set; }
        public long CPFTitular { get; set; }
        public Pessoa Titular { get; set; }
        public double Saldo { get; internal set; }
        public double ChequeEspecial { get; set; }
        public bool IsContaCorrente { get; set; }
        public DateTime DataUltimaOperacao { get; set; }
        public double SaldoTotal { get => this.Saldo + this.ChequeEspecial; }
        
    }
}
