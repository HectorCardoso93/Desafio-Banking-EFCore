using DesafioTecnicoBanking.Data;
using DesafioTecnicoBanking.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnicoBanking.Metodos
{
    public class Deposito
    {
        private BankingDataContext context;
        public Deposito()
        {
            context = new BankingDataContext();
        }
        public void MainDeposito(int indiceDestino, string nomeDepositante, double valor)
        {
            using(var context = new BankingDataContext())
            {
                var contaDestino = context.Contas.FirstOrDefault(x => x.NumeroConta == indiceDestino);
                contaDestino.Saldo += valor;
                context.Contas.Update(contaDestino);
                context.SaveChanges();

                MessageBox.Show($"Deposito efetuado com sucesso da Nome do depositante - ({nomeDepositante}) para conta - ({contaDestino.NumeroConta}) no valor de R${valor.ToString("F")}");
            }
        }
    }
}
