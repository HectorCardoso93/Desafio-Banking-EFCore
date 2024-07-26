namespace DesafioTecnicoBanking
{
    partial class FormConsultaSaldo
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
            label4 = new Label();
            textoAgencia = new TextBox();
            textoConta = new TextBox();
            textoSaldo = new TextBox();
            comboTitular = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            botaoVoltar = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 46);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Selecionar Conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 125);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Agência";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 172);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 2;
            label3.Text = "Número da conta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 123);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "Saldo";
            // 
            // textoAgencia
            // 
            textoAgencia.Location = new Point(245, 118);
            textoAgencia.Name = "textoAgencia";
            textoAgencia.ReadOnly = true;
            textoAgencia.Size = new Size(125, 27);
            textoAgencia.TabIndex = 4;
            // 
            // textoConta
            // 
            textoConta.Location = new Point(245, 169);
            textoConta.Name = "textoConta";
            textoConta.ReadOnly = true;
            textoConta.Size = new Size(125, 27);
            textoConta.TabIndex = 5;
            // 
            // textoSaldo
            // 
            textoSaldo.Location = new Point(201, 120);
            textoSaldo.Name = "textoSaldo";
            textoSaldo.ReadOnly = true;
            textoSaldo.Size = new Size(125, 27);
            textoSaldo.TabIndex = 6;
            // 
            // comboTitular
            // 
            comboTitular.FormattingEnabled = true;
            comboTitular.Location = new Point(232, 43);
            comboTitular.Name = "comboTitular";
            comboTitular.Size = new Size(151, 28);
            comboTitular.TabIndex = 7;
            comboTitular.SelectedIndexChanged += comboTitular_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(44, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 73);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Conta";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textoSaldo);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(44, 91);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 180);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações da conta";
            // 
            // botaoVoltar
            // 
            botaoVoltar.Location = new Point(58, 291);
            botaoVoltar.Name = "botaoVoltar";
            botaoVoltar.Size = new Size(94, 29);
            botaoVoltar.TabIndex = 10;
            botaoVoltar.Text = "Voltar";
            botaoVoltar.UseVisualStyleBackColor = true;
            botaoVoltar.Click += botaoVoltar_Click;
            // 
            // FormConsultaSaldo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 332);
            Controls.Add(botaoVoltar);
            Controls.Add(comboTitular);
            Controls.Add(textoConta);
            Controls.Add(textoAgencia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FormConsultaSaldo";
            Text = "FormConsultaSaldo";
            Load += FormConsultaSaldo_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textoAgencia;
        private TextBox textoConta;
        private TextBox textoSaldo;
        private ComboBox comboTitular;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button botaoVoltar;
    }
}