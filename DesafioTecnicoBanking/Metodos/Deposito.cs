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
        public void MainDeposito(int indiceDestino, int indiceDepositante, double valor)
        {
            using(var context = new BankingDataContext())
            {
                var contaDestino = context.Contas.FirstOrDefault(x => x.NumeroConta == indiceDestino);
                var contaDepositante = context.Contas.FirstOrDefault(x => x.NumeroConta == indiceDepositante);
                contaDepositante.Saldo -= valor;
                contaDestino.Saldo += valor;
                context.Contas.UpdateRange(contaDestino, contaDepositante);
                context.SaveChanges();

                MessageBox.Show($"Deposito efetuado com sucesso da conta - ({contaDepositante.NumeroConta}) para conta - ({contaDestino.NumeroConta}) no valor de R${valor.ToString("F")}");
            }
        }
    }
}
