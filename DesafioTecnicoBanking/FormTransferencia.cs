using DesafioTecnicoBanking.Data;
using DesafioTecnicoBanking.Metodos;
using DesafioTecnicoBanking.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioTecnicoBanking
{
    public partial class FormTransferencia : Form
    {
        private Transferencia transferir;
        public FormTransferencia(Form1 formPrincipal)
        {
            InitializeComponent();
            transferir = new Transferencia();
        }
        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTransferencia_Load(object sender, EventArgs e)
        {
            using (var context = new BankingDataContext())
            {
                var contas = context.Contas.ToList();
                foreach (var conta in contas)
                {
                    comboRemetente.Items.Add(conta.NumeroConta);
                    comboDestino.Items.Add(conta.NumeroConta);
                }
            }
        }

        private void botaoTransferir_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textoValor.Text);
            int indiceDestino = Convert.ToInt32(comboDestino.SelectedItem);
            int indiceRemetente = Convert.ToInt32(comboRemetente.SelectedItem);
            transferir.MainTransferencia(indiceDestino,indiceRemetente,valor);
        }
    }
}
