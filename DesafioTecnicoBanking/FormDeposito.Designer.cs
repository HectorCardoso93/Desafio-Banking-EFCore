namespace DesafioTecnicoBanking
{
    partial class FormDeposito
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
            comboDepositante = new ComboBox();
            comboDestino = new ComboBox();
            textoValor = new TextBox();
            botaoDeposito = new Button();
            botaoCancelar = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 42);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Conta Depositante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 96);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Conta Destino";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 136);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Valor:";
            // 
            // comboDepositante
            // 
            comboDepositante.FormattingEnabled = true;
            comboDepositante.Location = new Point(204, 39);
            comboDepositante.Name = "comboDepositante";
            comboDepositante.Size = new Size(151, 28);
            comboDepositante.TabIndex = 3;
            // 
            // comboDestino
            // 
            comboDestino.FormattingEnabled = true;
            comboDestino.Location = new Point(204, 93);
            comboDestino.Name = "comboDestino";
            comboDestino.Size = new Size(151, 28);
            comboDestino.TabIndex = 4;
            // 
            // textoValor
            // 
            textoValor.Location = new Point(192, 133);
            textoValor.Name = "textoValor";
            textoValor.Size = new Size(125, 27);
            textoValor.TabIndex = 5;
            // 
            // botaoDeposito
            // 
            botaoDeposito.Location = new Point(50, 191);
            botaoDeposito.Name = "botaoDeposito";
            botaoDeposito.Size = new Size(94, 29);
            botaoDeposito.TabIndex = 6;
            botaoDeposito.Text = "Depositar";
            botaoDeposito.UseVisualStyleBackColor = true;
            botaoDeposito.Click += botaoDeposito_Click;
            // 
            // botaoCancelar
            // 
            botaoCancelar.Location = new Point(201, 191);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(94, 29);
            botaoCancelar.TabIndex = 7;
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.UseVisualStyleBackColor = true;
            botaoCancelar.Click += botaoCancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(botaoCancelar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(botaoDeposito);
            groupBox1.Controls.Add(textoValor);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 257);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Depósito";
            // 
            // FormDeposito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 347);
            Controls.Add(comboDestino);
            Controls.Add(comboDepositante);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FormDeposito";
            Text = "FormDeposito";
            Load += FormDeposito_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboDepositante;
        private ComboBox comboDestino;
        private TextBox textoValor;
        private Button botaoDeposito;
        private Button botaoCancelar;
        private GroupBox groupBox1;
    }
}