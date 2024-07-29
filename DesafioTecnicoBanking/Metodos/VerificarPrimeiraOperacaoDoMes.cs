using DesafioTecnicoBanking.Data;
using DesafioTecnicoBanking.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnicoBanking.Metodos
{
    public class VerificarPrimeiraOperacaoDoMes
    {
        public VerificarPrimeiraOperacaoDoMes()
        {
        }
        public bool MainVerificarOperacao(int indiceConta)
        {
            DateTime dataAtual = DateTime.Now;
            using (var context = new BankingDataContext())
            {
                var conta = context.Contas.FirstOrDefault(x => x.NumeroConta == indiceConta);
                DateTime dataUltimaOperacao = conta.DataUltimaOperacao;
                if (!conta.IsContaCorrente)
                {
                    return true;
                }
                if (dataUltimaOperacao.Month != dataAtual.Month || dataUltimaOperacao.Year != dataAtual.Year)
                {
                    conta.DataUltimaOperacao = DateTime.Now;
                    context.Contas.Update(conta);
                    context.SaveChanges();
                    MessageBox.Show("Primeira operação do mês é gratuito.");
                    return true;
                }
                else
                {
                    conta.DataUltimaOperacao = DateTime.Now;
                    context.Contas.Update(conta);
                    context.SaveChanges();
                    return false;
                }
            }
        }
    }
}
