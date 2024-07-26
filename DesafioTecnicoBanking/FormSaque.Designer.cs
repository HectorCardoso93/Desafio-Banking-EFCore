namespace DesafioTecnicoBanking
{
    partial class FormSaque
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
            botaoSacar = new Button();
            comboTitulares = new ComboBox();
            textoValor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            botaoCancelar = new Button();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // botaoSacar
            // 
            botaoSacar.Location = new Point(59, 147);
            botaoSacar.Name = "botaoSacar";
            botaoSacar.Size = new Size(94, 29);
            botaoSacar.TabIndex = 0;
            botaoSacar.Text = "Sacar";
            botaoSacar.UseVisualStyleBackColor = true;
            botaoSacar.Click += botaoSacar_Click;
            // 
            // comboTitulares
            // 
            comboTitulares.FormattingEnabled = true;
            comboTitulares.Location = new Point(174, 27);
            comboTitulares.Name = "comboTitulares";
            comboTitulares.Size = new Size(151, 28);
            comboTitulares.TabIndex = 1;
            // 
            // textoValor
            // 
            textoValor.Location = new Point(174, 84);
            textoValor.Name = "textoValor";
            textoValor.Size = new Size(125, 27);
            textoValor.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 30);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 3;
            label1.Text = "Escolha a conta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 87);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 4;
            label2.Text = "Valor";
            // 
            // botaoCancelar
            // 
            botaoCancelar.Location = new Point(190, 147);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(94, 29);
            botaoCancelar.TabIndex = 0;
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.UseVisualStyleBackColor = true;
            botaoCancelar.Click += botaoCancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 190);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Saque";
            // 
            // FormSaque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 249);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textoValor);
            Controls.Add(comboTitulares);
            Controls.Add(botaoCancelar);
            Controls.Add(botaoSacar);
            Controls.Add(groupBox1);
            Name = "FormSaque";
            Text = "Saque";
            Load += FormSaque_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botaoSacar;
        private ComboBox comboTitulares;
        private TextBox textoValor;
        private Label label1;
        private Label label2;
        private Button botaoCancelar;
        private GroupBox groupBox1;
    }
}