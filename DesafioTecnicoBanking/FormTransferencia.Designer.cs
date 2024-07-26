namespace DesafioTecnicoBanking
{
    partial class FormTransferencia
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
            groupBox1 = new GroupBox();
            textoValor = new TextBox();
            comboRemetente = new ComboBox();
            comboDestino = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            botaoCancelar = new Button();
            botaoTransferir = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textoValor);
            groupBox1.Controls.Add(comboRemetente);
            groupBox1.Controls.Add(comboDestino);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(botaoCancelar);
            groupBox1.Controls.Add(botaoTransferir);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 260);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transferência";
            // 
            // textoValor
            // 
            textoValor.Location = new Point(173, 137);
            textoValor.Name = "textoValor";
            textoValor.Size = new Size(125, 27);
            textoValor.TabIndex = 5;
            // 
            // comboRemetente
            // 
            comboRemetente.FormattingEnabled = true;
            comboRemetente.Location = new Point(173, 40);
            comboRemetente.Name = "comboRemetente";
            comboRemetente.Size = new Size(151, 28);
            comboRemetente.TabIndex = 1;
            // 
            // comboDestino
            // 
            comboDestino.FormattingEnabled = true;
            comboDestino.Location = new Point(173, 88);
            comboDestino.Name = "comboDestino";
            comboDestino.Size = new Size(151, 28);
            comboDestino.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 140);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 91);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Destino";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 43);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "Remetente";
            // 
            // botaoCancelar
            // 
            botaoCancelar.Location = new Point(207, 204);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(94, 29);
            botaoCancelar.TabIndex = 1;
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.UseVisualStyleBackColor = true;
            botaoCancelar.Click += botaoCancelar_Click;
            // 
            // botaoTransferir
            // 
            botaoTransferir.Location = new Point(66, 204);
            botaoTransferir.Name = "botaoTransferir";
            botaoTransferir.Size = new Size(94, 29);
            botaoTransferir.TabIndex = 0;
            botaoTransferir.Text = "Transferir";
            botaoTransferir.UseVisualStyleBackColor = true;
            botaoTransferir.Click += botaoTransferir_Click;
            // 
            // FormTransferencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 343);
            Controls.Add(groupBox1);
            Name = "FormTransferencia";
            Text = "FormTransferencia";
            Load += FormTransferencia_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button botaoCancelar;
        private Button botaoTransferir;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textoValor;
        private ComboBox comboRemetente;
        private ComboBox comboDestino;
    }
}