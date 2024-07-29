using DesafioTecnicoBanking.Modelos;
using DesafioTecnicoBanking.Metodos;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesafioTecnicoBanking.Data;
using static System.Net.Mime.MediaTypeNames;

namespace DesafioTecnicoBanking
{
    public partial class FormConsultaSaldo : Form
    {
        private ConsultarSaldo consultarSaldo;
        public FormConsultaSaldo(Form1 formPrincipal)
        {
            InitializeComponent(); 
            consultarSaldo = new ConsultarSaldo();
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConsultaSaldo_Load(object sender, EventArgs e)
        {
            using(var context = new BankingDataContext())
            {
                var contas = context.Contas.ToList();
                foreach (var conta in contas)
                {
                    comboTitular.Items.Add(conta.NumeroConta);
                }
            }
        }

        private void comboTitular_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(var context = new BankingDataContext())
            {
                int indiceConta = Convert.ToInt32(comboTitular.SelectedItem);
                consultarSaldo.MainConsultaSaldo(indiceConta);
                var conta = context.Contas.FirstOrDefault(x => x.NumeroConta == indiceConta);
                textoAgencia.Text = Convert.ToString(conta.Agencia);
                textoConta.Text = Convert.ToString(conta.NumeroConta);
                textoSaldo.Text = Convert.ToString(conta.Saldo);
            }
        }
    }
}
