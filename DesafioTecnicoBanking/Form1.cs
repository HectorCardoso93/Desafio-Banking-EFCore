using DesafioTecnicoBanking.Data;
using DesafioTecnicoBanking.Modelos;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace DesafioTecnicoBanking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoAdicionarConta_Click(object sender, EventArgs e)
        {
            FormNovaConta formularioNovaConta = new FormNovaConta(this);
            formularioNovaConta.ShowDialog();
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            FormDeposito formularioDeposito = new FormDeposito(this);
            formularioDeposito.ShowDialog();
        }

        private void botaoSaldo_Click(object sender, EventArgs e)
        {
            FormConsultaSaldo formularioConsulta = new FormConsultaSaldo(this);
            formularioConsulta.ShowDialog();
        }

        private void botaoExtrato_Click(object sender, EventArgs e)
        {
            FormExtrato formularioExtrato = new FormExtrato(this);
            formularioExtrato.ShowDialog();
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            FormSaque formularioSaque = new FormSaque(this);
            formularioSaque.ShowDialog();
        }

        private void botaoTransferir_Click(object sender, EventArgs e)
        {
            FormTransferencia formularioTransferencia = new FormTransferencia(this);
            formularioTransferencia.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(var context = new BankingDataContext())
            {
                var contas = context.Contas.ToList();
                foreach (var conta in contas)
                    comboContas.Items.Add(conta.NumeroConta);
            }
            
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(var context = new BankingDataContext())
            {
                string indice = comboContas.Text;
                var selecionada = context.Contas.FirstOrDefault(x => x.NumeroConta == Convert.ToInt32(indice));

                textoAgencia.Text = Convert.ToString(selecionada.Agencia);
                textoNumeroConta.Text = Convert.ToString(selecionada.NumeroConta);
                //textoTitular.Text = conta.;
            }
        }
    }
}
