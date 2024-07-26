using DesafioTecnicoBanking.Data;
using DesafioTecnicoBanking.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnicoBanking.Metodos
{
    public class Transferencia
    {
        private VerificarPrimeiraOperacaoDoMes verificacao;
        public Transferencia()
        {
            verificacao = new VerificarPrimeiraOperacaoDoMes();
        }
        public void MainTransferencia(int indiceDestino, int indiceRemetente, double valor)
        {
            bool verificado = verificacao.MainVerificarOperacao(indiceRemetente);
            using (var context = new BankingDataContext())
            {
                var contaDestino = context.Contas.FirstOrDefault(x => x.NumeroConta == indiceDestino);
                var contaRemetente = context.Contas.FirstOrDefault(x => x.NumeroConta == indiceRemetente);

                if (contaRemetente.IsContaCorrente != contaDestino.IsContaCorrente)
                {
                    MessageBox.Show("Transferência de conta poupança para conta corrente não é permitida.");
                    return;
                }

                if(verificado || !contaRemetente.IsContaCorrente)
                {
                    contaDestino.Saldo += valor;
                    contaRemetente.Saldo -= valor;

                    context.Contas.UpdateRange(contaDestino, contaRemetente);
                    context.SaveChanges();
                    MessageBox.Show($"Sua transferência foi concluída da conta ({contaRemetente.NumeroConta}) para ({contaDestino.NumeroConta}) no valor de R${valor.ToString("F")}");
                    MessageBox.Show($"Seu saldo foi para {contaRemetente.Saldo}");
                }
                else
                {
                    double operacaoTransferencia = 2.25;
                    MessageBox.Show($"Para essa operação descontamos {operacaoTransferencia} do seu saldo.");
                    contaDestino.Saldo += valor;
                    contaRemetente.Saldo -= (valor + operacaoTransferencia);

                    context.Contas.UpdateRange(contaDestino, contaRemetente);
                    context.SaveChanges();
                    MessageBox.Show($"Sua transferência foi concluída da conta ({contaRemetente.NumeroConta}) para ({contaDestino.NumeroConta}) no valor de R${valor.ToString("F")}");
                    MessageBox.Show($"Seu saldo foi para {contaRemetente.Saldo}");
                }
            }
        }
    }
}
