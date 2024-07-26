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
    public partial class FormSaque : Form
    {
        private Saque saque;
        public FormSaque(Form1 formPrincipal)
        {
            InitializeComponent();
            saque = new Saque();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSaque_Load(object sender, EventArgs e)
        {
            using (var context = new BankingDataContext())
            {
                var contas = context.Contas.ToList();
                foreach (var conta in contas)
                {
                    comboTitulares.Items.Add(conta.NumeroConta);
                }
            }
        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textoValor.Text);
            int indice = Convert.ToInt32(comboTitulares.SelectedItem);
            saque.MainSaque(indice,valor);
        }
    }
}
