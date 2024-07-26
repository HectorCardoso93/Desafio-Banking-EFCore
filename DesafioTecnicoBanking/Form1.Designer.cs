namespace DesafioTecnicoBanking
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botaoAdicionarConta = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textoAgencia = new TextBox();
            textoNumeroConta = new TextBox();
            textoTitular = new TextBox();
            botaoDeposito = new Button();
            botaoSaldo = new Button();
            botaoExtrato = new Button();
            botaoSaque = new Button();
            botaoTransferir = new Button();
            comboContas = new ComboBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // botaoAdicionarConta
            // 
            botaoAdicionarConta.Location = new Point(16, 38);
            botaoAdicionarConta.Name = "botaoAdicionarConta";
            botaoAdicionarConta.Size = new Size(134, 29);
            botaoAdicionarConta.TabIndex = 0;
            botaoAdicionarConta.Text = "Nova Conta";
            botaoAdicionarConta.UseVisualStyleBackColor = true;
            botaoAdicionarConta.Click += botaoAdicionarConta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 73);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 1;
            label1.Text = "Agência";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 117);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 2;
            label2.Text = "Número da Conta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 161);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 3;
            label3.Text = "Titular";
            // 
            // textoAgencia
            // 
            textoAgencia.Location = new Point(218, 70);
            textoAgencia.Name = "textoAgencia";
            textoAgencia.ReadOnly = true;
            textoAgencia.Size = new Size(125, 27);
            textoAgencia.TabIndex = 4;
            // 
            // textoNumeroConta
            // 
            textoNumeroConta.Location = new Point(218, 114);
            textoNumeroConta.Name = "textoNumeroConta";
            textoNumeroConta.ReadOnly = true;
            textoNumeroConta.Size = new Size(125, 27);
            textoNumeroConta.TabIndex = 5;
            // 
            // textoTitular
            // 
            textoTitular.Location = new Point(218, 158);
            textoTitular.Name = "textoTitular";
            textoTitular.ReadOnly = true;
            textoTitular.Size = new Size(125, 27);
            textoTitular.TabIndex = 6;
            // 
            // botaoDeposito
            // 
            botaoDeposito.Location = new Point(16, 90);
            botaoDeposito.Name = "botaoDeposito";
            botaoDeposito.Size = new Size(134, 29);
            botaoDeposito.TabIndex = 9;
            botaoDeposito.Text = "Depósito";
            botaoDeposito.UseVisualStyleBackColor = true;
            botaoDeposito.Click += botaoDeposito_Click;
            // 
            // botaoSaldo
            // 
            botaoSaldo.Location = new Point(16, 146);
            botaoSaldo.Name = "botaoSaldo";
            botaoSaldo.Size = new Size(134, 29);
            botaoSaldo.TabIndex = 10;
            botaoSaldo.Text = "Consultar Saldo";
            botaoSaldo.UseVisualStyleBackColor = true;
            botaoSaldo.Click += botaoSaldo_Click;
            // 
            // botaoExtrato
            // 
            botaoExtrato.Location = new Point(260, 38);
            botaoExtrato.Name = "botaoExtrato";
            botaoExtrato.Size = new Size(134, 29);
            botaoExtrato.TabIndex = 11;
            botaoExtrato.Text = "Extrato";
            botaoExtrato.UseVisualStyleBackColor = true;
            botaoExtrato.Click += botaoExtrato_Click;
            // 
            // botaoSaque
            // 
            botaoSaque.Location = new Point(258, 90);
            botaoSaque.Name = "botaoSaque";
            botaoSaque.Size = new Size(136, 29);
            botaoSaque.TabIndex = 12;
            botaoSaque.Text = "Saque";
            botaoSaque.UseVisualStyleBackColor = true;
            botaoSaque.Click += botaoSaque_Click;
            // 
            // botaoTransferir
            // 
            botaoTransferir.Location = new Point(260, 146);
            botaoTransferir.Name = "botaoTransferir";
            botaoTransferir.Size = new Size(134, 29);
            botaoTransferir.TabIndex = 13;
            botaoTransferir.Text = "Transferência";
            botaoTransferir.UseVisualStyleBackColor = true;
            botaoTransferir.Click += botaoTransferir_Click;
            // 
            // comboContas
            // 
            comboContas.FormattingEnabled = true;
            comboContas.Location = new Point(251, 34);
            comboContas.Name = "comboContas";
            comboContas.Size = new Size(191, 28);
            comboContas.TabIndex = 14;
            comboContas.SelectedIndexChanged += comboContas_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 42);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 15;
            label5.Text = "Selecionar Conta:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textoAgencia);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textoNumeroConta);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textoTitular);
            groupBox1.Location = new Point(33, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 201);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(botaoSaldo);
            groupBox2.Controls.Add(botaoAdicionarConta);
            groupBox2.Controls.Add(botaoTransferir);
            groupBox2.Controls.Add(botaoDeposito);
            groupBox2.Controls.Add(botaoSaque);
            groupBox2.Controls.Add(botaoExtrato);
            groupBox2.Location = new Point(33, 243);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(443, 195);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selecionar Opção";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 450);
            Controls.Add(label5);
            Controls.Add(comboContas);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botaoAdicionarConta;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textoAgencia;
        private TextBox textoNumeroConta;
        private TextBox textoTitular;
        private Button botaoDeposito;
        private Button botaoSaldo;
        private Button botaoExtrato;
        private Button botaoSaque;
        private Button botaoTransferir;
        private ComboBox comboContas;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
