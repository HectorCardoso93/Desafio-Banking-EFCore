using DesafioTecnicoBanking.Data;
using DesafioTecnicoBanking.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnicoBanking.Metodos
{
    public class Saque
    {
        private VerificarPrimeiraOperacaoDoMes verificacao;
        public Saque()
        {
            verificacao = new VerificarPrimeiraOperacaoDoMes();
        }
        public void MainSaque(int indiceConta, double valor)
        {
            bool verificado = verificacao.MainVerificarOperacao(indiceConta);
            using (var context = new BankingDataContext())
            {
                var conta = context.Contas.FirstOrDefault(x => x.NumeroConta == indiceConta);
                if(conta.SaldoTotal > valor)
                {
                    if (verificado || !conta.IsContaCorrente)
                    {
                        conta.Saldo -= valor;
                        context.Contas.Update(conta);
                        context.SaveChanges();
                        MessageBox.Show($"O saldo da conta {conta.NumeroConta} foi para {conta.Saldo}");
                    }
                    else
                    {
                        double operacaoSaque = 4.77;
                        MessageBox.Show($"Para essa operação descontamos {operacaoSaque} do seu saldo.");
                        conta.Saldo -= (valor + operacaoSaque);
                        context.Contas.Update(conta);
                        context.SaveChanges();
                        MessageBox.Show($"O saldo da conta {conta.NumeroConta} foi para {conta.Saldo}");
                        MessageBox.Show($"Seu saldo foi para {conta.Saldo}");
                    }
                }
                else
                {
                    MessageBox.Show("Valor do saque é maior que o seu saldo.");
                }
            }
        }
    }
}
