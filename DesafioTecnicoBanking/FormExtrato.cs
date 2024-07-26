using DesafioTecnicoBanking.Data;
using DesafioTecnicoBanking.Metodos;
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
    public partial class FormExtrato : Form
    {
        private Extrato extrato;
        public FormExtrato(Form1 formPrincipal)
        {
            InitializeComponent();
            extrato = new Extrato();
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(comboExtrato.SelectedItem);
            extrato.MainExtrato(indice);
        }

        private void FormExtrato_Load(object sender, EventArgs e)
        {
            using(var context = new BankingDataContext())
            {
                var contas = context.Contas.ToList();
                foreach (var conta in contas)
                {
                    comboExtrato.Items.Add(conta.NumeroConta);
                }
            }
        }
    }
}
