namespace DesafioTecnicoBanking
{
    partial class FormNovaConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textoAgencia = new TextBox();
            textoConta = new TextBox();
            textoTitular = new TextBox();
            groupBox1 = new GroupBox();
            textoCPF = new TextBox();
            label5 = new Label();
            label4 = new Label();
            comboTipoDeConta = new ComboBox();
            botaoCancelar = new Button();
            botaoCriar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 97);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Agência";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 146);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 0;
            label2.Text = "NumeroConta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 197);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 0;
            label3.Text = "Nome do titular";
            // 
            // textoAgencia
            // 
            textoAgencia.Location = new Point(184, 90);
            textoAgencia.Name = "textoAgencia";
            textoAgencia.ReadOnly = true;
            textoAgencia.Size = new Size(169, 27);
            textoAgencia.TabIndex = 1;
            textoAgencia.Text = "100";
            // 
            // textoConta
            // 
            textoConta.Location = new Point(184, 139);
            textoConta.Name = "textoConta";
            textoConta.ReadOnly = true;
            textoConta.Size = new Size(169, 27);
            textoConta.TabIndex = 2;
            // 
            // textoTitular
            // 
            textoTitular.Location = new Point(184, 190);
            textoTitular.Name = "textoTitular";
            textoTitular.Size = new Size(169, 27);
            textoTitular.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textoCPF);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboTipoDeConta);
            groupBox1.Controls.Add(botaoCancelar);
            groupBox1.Controls.Add(botaoCriar);
            groupBox1.Location = new Point(12, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(692, 323);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nova Conta";
            // 
            // textoCPF
            // 
            textoCPF.Location = new Point(172, 203);
            textoCPF.Name = "textoCPF";
            textoCPF.Size = new Size(169, 27);
            textoCPF.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 210);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 0;
            label5.Text = "CPF do titular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 56);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 0;
            label4.Text = "Tipo de Conta";
            // 
            // comboTipoDeConta
            // 
            comboTipoDeConta.FormattingEnabled = true;
            comboTipoDeConta.Items.AddRange(new object[] { "Conta Corrente", "Conta Poupança" });
            comboTipoDeConta.Location = new Point(525, 49);
            comboTipoDeConta.Name = "comboTipoDeConta";
            comboTipoDeConta.Size = new Size(151, 28);
            comboTipoDeConta.TabIndex = 5;
            // 
            // botaoCancelar
            // 
            botaoCancelar.Location = new Point(185, 258);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(94, 29);
            botaoCancelar.TabIndex = 7;
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.UseVisualStyleBackColor = true;
            botaoCancelar.Click += botaoCancelar_Click;
            // 
            // botaoCriar
            // 
            botaoCriar.Location = new Point(43, 258);
            botaoCriar.Name = "botaoCriar";
            botaoCriar.Size = new Size(94, 29);
            botaoCriar.TabIndex = 6;
            botaoCriar.Text = "Criar";
            botaoCriar.UseVisualStyleBackColor = true;
            botaoCriar.Click += botaoCriar_Click;
            // 
            // FormNovaConta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textoTitular);
            Controls.Add(textoConta);
            Controls.Add(textoAgencia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FormNovaConta";
            Text = "FormNovaConta";
            Load += FormNovaConta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textoAgencia;
        private TextBox textoConta;
        private TextBox textoTitular;
        private GroupBox groupBox1;
        private Button botaoCancelar;
        private Button botaoCriar;
        private Label label4;
        private ComboBox comboTipoDeConta;
        private TextBox textoCPF;
        private Label label5;
    }
}