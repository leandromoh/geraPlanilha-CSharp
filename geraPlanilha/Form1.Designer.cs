namespace geraPlanilha
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGeraPlanilha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuarda1 = new System.Windows.Forms.TextBox();
            this.txtGuarda2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuarda3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnG3 = new System.Windows.Forms.RadioButton();
            this.rbtnG2 = new System.Windows.Forms.RadioButton();
            this.rbtnG1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnDia2 = new System.Windows.Forms.RadioButton();
            this.rbtnDia1 = new System.Windows.Forms.RadioButton();
            this.txtMes = new System.Windows.Forms.NumericUpDown();
            this.txtAno = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeraPlanilha
            // 
            this.btnGeraPlanilha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraPlanilha.Location = new System.Drawing.Point(103, 330);
            this.btnGeraPlanilha.Name = "btnGeraPlanilha";
            this.btnGeraPlanilha.Size = new System.Drawing.Size(159, 44);
            this.btnGeraPlanilha.TabIndex = 10;
            this.btnGeraPlanilha.Text = "Gerar Planilha";
            this.btnGeraPlanilha.UseVisualStyleBackColor = true;
            this.btnGeraPlanilha.Click += new System.EventHandler(this.btnGeraPlanilha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Guarda 1:";
            // 
            // txtGuarda1
            // 
            this.txtGuarda1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuarda1.Location = new System.Drawing.Point(147, 12);
            this.txtGuarda1.Name = "txtGuarda1";
            this.txtGuarda1.Size = new System.Drawing.Size(195, 22);
            this.txtGuarda1.TabIndex = 0;
            this.txtGuarda1.Text = "Sebastião";
            // 
            // txtGuarda2
            // 
            this.txtGuarda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuarda2.Location = new System.Drawing.Point(147, 56);
            this.txtGuarda2.Name = "txtGuarda2";
            this.txtGuarda2.Size = new System.Drawing.Size(195, 22);
            this.txtGuarda2.TabIndex = 4;
            this.txtGuarda2.Text = "Orlando";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Guarda 2:";
            // 
            // txtGuarda3
            // 
            this.txtGuarda3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuarda3.Location = new System.Drawing.Point(147, 104);
            this.txtGuarda3.Name = "txtGuarda3";
            this.txtGuarda3.Size = new System.Drawing.Size(195, 22);
            this.txtGuarda3.TabIndex = 6;
            this.txtGuarda3.Text = "Manoel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome do Guarda 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ano Planilha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mês Inicial:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnG3);
            this.groupBox1.Controls.Add(this.rbtnG2);
            this.groupBox1.Controls.Add(this.rbtnG1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(19, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 117);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primeiro folgante do Mes?";
            // 
            // rbtnG3
            // 
            this.rbtnG3.AutoSize = true;
            this.rbtnG3.Location = new System.Drawing.Point(19, 81);
            this.rbtnG3.Name = "rbtnG3";
            this.rbtnG3.Size = new System.Drawing.Size(81, 20);
            this.rbtnG3.TabIndex = 2;
            this.rbtnG3.Text = "Guarda 3";
            this.rbtnG3.UseVisualStyleBackColor = true;
            // 
            // rbtnG2
            // 
            this.rbtnG2.AutoSize = true;
            this.rbtnG2.Location = new System.Drawing.Point(19, 55);
            this.rbtnG2.Name = "rbtnG2";
            this.rbtnG2.Size = new System.Drawing.Size(81, 20);
            this.rbtnG2.TabIndex = 1;
            this.rbtnG2.Text = "Guarda 2";
            this.rbtnG2.UseVisualStyleBackColor = true;
            // 
            // rbtnG1
            // 
            this.rbtnG1.AutoSize = true;
            this.rbtnG1.Checked = true;
            this.rbtnG1.Location = new System.Drawing.Point(19, 29);
            this.rbtnG1.Name = "rbtnG1";
            this.rbtnG1.Size = new System.Drawing.Size(81, 20);
            this.rbtnG1.TabIndex = 0;
            this.rbtnG1.TabStop = true;
            this.rbtnG1.Text = "Guarda 1";
            this.rbtnG1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnDia2);
            this.groupBox2.Controls.Add(this.rbtnDia1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(19, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 48);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dia da 1ª  folga do mês inicial:";
            // 
            // rbtnDia2
            // 
            this.rbtnDia2.AutoSize = true;
            this.rbtnDia2.Location = new System.Drawing.Point(105, 21);
            this.rbtnDia2.Name = "rbtnDia2";
            this.rbtnDia2.Size = new System.Drawing.Size(33, 20);
            this.rbtnDia2.TabIndex = 1;
            this.rbtnDia2.Text = "2";
            this.rbtnDia2.UseVisualStyleBackColor = true;
            // 
            // rbtnDia1
            // 
            this.rbtnDia1.AutoSize = true;
            this.rbtnDia1.Checked = true;
            this.rbtnDia1.Location = new System.Drawing.Point(46, 21);
            this.rbtnDia1.Name = "rbtnDia1";
            this.rbtnDia1.Size = new System.Drawing.Size(33, 20);
            this.rbtnDia1.TabIndex = 0;
            this.rbtnDia1.TabStop = true;
            this.rbtnDia1.Text = "1";
            this.rbtnDia1.UseVisualStyleBackColor = true;
            // 
            // txtMes
            // 
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMes.Location = new System.Drawing.Point(243, 213);
            this.txtMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(93, 22);
            this.txtMes.TabIndex = 15;
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAno.Location = new System.Drawing.Point(243, 160);
            this.txtAno.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.txtAno.Minimum = new decimal(new int[] {
            1901,
            0,
            0,
            0});
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(93, 22);
            this.txtAno.TabIndex = 16;
            this.txtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAno.Value = new decimal(new int[] {
            1901,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 386);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGuarda3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGuarda2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGuarda1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeraPlanilha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "geraPlanilha 2.10";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeraPlanilha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuarda1;
        private System.Windows.Forms.TextBox txtGuarda2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuarda3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnG3;
        private System.Windows.Forms.RadioButton rbtnG2;
        private System.Windows.Forms.RadioButton rbtnG1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnDia2;
        private System.Windows.Forms.RadioButton rbtnDia1;
        private System.Windows.Forms.NumericUpDown txtMes;
        private System.Windows.Forms.NumericUpDown txtAno;
    }
}

