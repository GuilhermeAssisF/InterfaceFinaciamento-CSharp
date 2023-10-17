namespace Projeto_1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.principal = new System.Windows.Forms.TextBox();
            this.numeroDeParcelas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.taxaDeJurosAnual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculoJuros = new System.Windows.Forms.Button();
            this.valorPago = new System.Windows.Forms.Label();
            this.totalJuros = new System.Windows.Forms.Label();
            this.resultadoFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor do Financiamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(-4, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 460);
            this.panel1.TabIndex = 1;
            // 
            // principal
            // 
            this.principal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.principal.Location = new System.Drawing.Point(294, 78);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(336, 22);
            this.principal.TabIndex = 2;
            this.principal.TextChanged += new System.EventHandler(this.principal_TextChanged);
            // 
            // numeroDeParcelas
            // 
            this.numeroDeParcelas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numeroDeParcelas.Location = new System.Drawing.Point(294, 210);
            this.numeroDeParcelas.Name = "numeroDeParcelas";
            this.numeroDeParcelas.Size = new System.Drawing.Size(336, 22);
            this.numeroDeParcelas.TabIndex = 4;
            this.numeroDeParcelas.TextChanged += new System.EventHandler(this.numeroDeParcelas_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parcelas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // taxaDeJurosAnual
            // 
            this.taxaDeJurosAnual.BackColor = System.Drawing.SystemColors.HighlightText;
            this.taxaDeJurosAnual.Location = new System.Drawing.Point(294, 146);
            this.taxaDeJurosAnual.Name = "taxaDeJurosAnual";
            this.taxaDeJurosAnual.Size = new System.Drawing.Size(336, 22);
            this.taxaDeJurosAnual.TabIndex = 6;
            this.taxaDeJurosAnual.TextChanged += new System.EventHandler(this.taxaDeJurosMensal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Taxa de Juros";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCalculoJuros
            // 
            this.btnCalculoJuros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCalculoJuros.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculoJuros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalculoJuros.Location = new System.Drawing.Point(294, 248);
            this.btnCalculoJuros.Name = "btnCalculoJuros";
            this.btnCalculoJuros.Size = new System.Drawing.Size(336, 39);
            this.btnCalculoJuros.TabIndex = 7;
            this.btnCalculoJuros.Text = "CALCULAR";
            this.btnCalculoJuros.UseVisualStyleBackColor = false;
            this.btnCalculoJuros.Click += new System.EventHandler(this.btnCalculoJuros_Click);
            // 
            // valorPago
            // 
            this.valorPago.AutoSize = true;
            this.valorPago.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorPago.Location = new System.Drawing.Point(289, 301);
            this.valorPago.Name = "valorPago";
            this.valorPago.Size = new System.Drawing.Size(187, 27);
            this.valorPago.TabIndex = 8;
            this.valorPago.Text = "Valor da Parcela: ";
            // 
            // totalJuros
            // 
            this.totalJuros.AutoSize = true;
            this.totalJuros.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalJuros.Location = new System.Drawing.Point(311, 340);
            this.totalJuros.Name = "totalJuros";
            this.totalJuros.Size = new System.Drawing.Size(166, 27);
            this.totalJuros.TabIndex = 9;
            this.totalJuros.Text = "Total de Juros: ";
            // 
            // resultadoFinal
            // 
            this.resultadoFinal.AutoSize = true;
            this.resultadoFinal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoFinal.Location = new System.Drawing.Point(346, 381);
            this.resultadoFinal.Name = "resultadoFinal";
            this.resultadoFinal.Size = new System.Drawing.Size(136, 27);
            this.resultadoFinal.TabIndex = 10;
            this.resultadoFinal.Text = "Total Final:  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultadoFinal);
            this.Controls.Add(this.totalJuros);
            this.Controls.Add(this.valorPago);
            this.Controls.Add(this.btnCalculoJuros);
            this.Controls.Add(this.taxaDeJurosAnual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numeroDeParcelas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.principal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox principal;
        private System.Windows.Forms.TextBox numeroDeParcelas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taxaDeJurosAnual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculoJuros;
        private System.Windows.Forms.Label valorPago;
        private System.Windows.Forms.Label totalJuros;
        private System.Windows.Forms.Label resultadoFinal;
    }
}

