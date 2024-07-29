using DesafioTecnicoBanking.Data;
using DesafioTecnicoBanking.Metodos;
using DesafioTecnicoBanking.Modelos;
using MySql.Data.MySqlClient;
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
    public partial class FormDeposito : Form
    {
        private Deposito depositos;

        public FormDeposito(Form1 formPrincipal)
        {
            InitializeComponent();
            depositos = new Deposito();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDeposito_Load(object sender, EventArgs e)
        {
            using(var context = new BankingDataContext())
            {
                var contas = context.Contas.ToList();
                foreach (var conta in contas)
                {
                    comboDestino.Items.Add(conta.NumeroConta);
                }
            }
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            using(var context = new BankingDataContext())
            {
                int indiceDestino = Convert.ToInt32(comboDestino.SelectedItem);
                double valor = Convert.ToDouble(textoValor.Text);
                string nomeDepositante = textoDepositante.Text;
                depositos.MainDeposito(indiceDestino, nomeDepositante, valor);
            }
        }
    }
}
