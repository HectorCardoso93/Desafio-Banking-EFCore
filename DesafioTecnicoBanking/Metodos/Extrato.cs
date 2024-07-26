using DesafioTecnicoBanking.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnicoBanking.Metodos
{
    public class Extrato
    {
        private VerificarPrimeiraOperacaoDoMes verificacao;
        public Extrato()
        {
            verificacao = new VerificarPrimeiraOperacaoDoMes();
        }
        public void MainExtrato(int indiceConta)
        {
            bool verificado = verificacao.MainVerificarOperacao(indiceConta);

            using(var context = new BankingDataContext())
            {
                if (verificado)
                {
                    MessageBox.Show("Primeira operação do mês é gratuito.");
                }
                else
                {

                    var conta = context.Contas.FirstOrDefault(x => x.NumeroConta == indiceConta);
                    double operacaoConsultaSaldo = 3.82;
                    conta.Saldo -= operacaoConsultaSaldo;
                    MessageBox.Show($"A operação de extrato foi feita e seu saldo é de {conta.Saldo.ToString("F")}");
                }

            }
        }
    }
}
