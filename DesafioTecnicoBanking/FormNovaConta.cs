using DesafioTecnicoBanking.Data;
using DesafioTecnicoBanking.Modelos;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormNovaConta : Form
    {

        public FormNovaConta(Form1 formPrincipal)
        {
            InitializeComponent();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoCriar_Click(object sender, EventArgs e)
        {
            var tipoDeConta = comboTipoDeConta.SelectedIndex == 0 ? true : false;
            var pessoa = new Pessoa
            {
                Cpf = Convert.ToInt64(textoCPF.Text),
                Nome = textoTitular.Text
            };

            var conta = new Conta
            {
                //NumeroConta = Convert.ToInt32(textoConta.Text),
                Titular = pessoa,
                IsContaCorrente = tipoDeConta
            };
            using(var context = new BankingDataContext())
            {
                context.Contas.Add(conta);

                context.SaveChanges();
            }

            MessageBox.Show($"A conta foi criada com o Numero: {conta.NumeroConta} e o Titular: {conta.Titular.Nome}");

            FormNovaConta_Load(sender, e);
            textoCPF.Text = "";
            textoTitular.Text = "";
            comboTipoDeConta.SelectedIndex = -1;
        }

        private void FormNovaConta_Load(object sender, EventArgs e)
        {
            using(var context = new BankingDataContext())
            {
                var numeroConta = context.Contas.Max(x => x.NumeroConta);
                textoConta.Text = Convert.ToString(numeroConta + 1);
            }
        }
    }
}
