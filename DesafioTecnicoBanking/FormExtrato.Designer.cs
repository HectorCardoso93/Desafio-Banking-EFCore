namespace DesafioTecnicoBanking
{
    partial class FormExtrato
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
            Extrato = new ListBox();
            label1 = new Label();
            comboExtrato = new ComboBox();
            botaoVoltar = new Button();
            SuspendLayout();
            // 
            // Extrato
            // 
            Extrato.FormattingEnabled = true;
            Extrato.Location = new Point(12, 58);
            Extrato.Name = "Extrato";
            Extrato.Size = new Size(429, 224);
            Extrato.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 1;
            label1.Text = "Escolha a conta:";
            // 
            // comboExtrato
            // 
            comboExtrato.FormattingEnabled = true;
            comboExtrato.Location = new Point(153, 17);
            comboExtrato.Name = "comboExtrato";
            comboExtrato.Size = new Size(151, 28);
            comboExtrato.TabIndex = 2;
            comboExtrato.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // botaoVoltar
            // 
            botaoVoltar.Location = new Point(23, 304);
            botaoVoltar.Name = "botaoVoltar";
            botaoVoltar.Size = new Size(94, 29);
            botaoVoltar.TabIndex = 3;
            botaoVoltar.Text = "Voltar";
            botaoVoltar.UseVisualStyleBackColor = true;
            botaoVoltar.Click += botaoVoltar_Click;
            // 
            // FormExtrato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botaoVoltar);
            Controls.Add(comboExtrato);
            Controls.Add(label1);
            Controls.Add(Extrato);
            Name = "FormExtrato";
            Text = "Extrato";
            Load += FormExtrato_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Extrato;
        private Label label1;
        private ComboBox comboExtrato;
        private Button botaoVoltar;
    }
}