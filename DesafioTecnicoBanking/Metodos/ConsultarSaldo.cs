using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioTecnicoBanking.Data;
using DesafioTecnicoBanking.Modelos;

namespace DesafioTecnicoBanking.Metodos
{
    public class ConsultarSaldo
    {
        private VerificarPrimeiraOperacaoDoMes verificacao;
        public ConsultarSaldo()
        {
            verificacao = new VerificarPrimeiraOperacaoDoMes();
        }
        public void MainConsultaSaldo(int indiceConta)
        {
            bool verificado = verificacao.MainVerificarOperacao(indiceConta);
            using(var context = new BankingDataContext())
            {
                var conta = context.Contas.FirstOrDefault(x => x.NumeroConta == indiceConta);
                if (!conta.IsContaCorrente || verificado)
                {
                    MessageBox.Show($"Seu saldo é de {conta.Saldo.ToString("F")}");
                    return;
                }
                else
                {
                    double operacaoConsultaSaldo = 1.37;
                    conta.Saldo -= operacaoConsultaSaldo;
                    MessageBox.Show($"A operação de saque foi feita e seu saldo é de {conta.Saldo.ToString("F")}");
                }
            }
        }
    }
}
