namespace KetClass.View.Cursos
{
    partial class CriarCurso
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.tbxAno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pesPeriodo = new KetClass.View.Shared.UCPesquisa();
            this.pesUnidade = new KetClass.View.Shared.UCPesquisa();
            this.tbxPSerie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxUSerie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(328, 146);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(247, 146);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição";
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(15, 25);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(127, 20);
            this.tbxDescricao.TabIndex = 3;
            // 
            // tbxAno
            // 
            this.tbxAno.Location = new System.Drawing.Point(148, 25);
            this.tbxAno.Name = "tbxAno";
            this.tbxAno.Size = new System.Drawing.Size(56, 20);
            this.tbxAno.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Período";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unidade";
            // 
            // pesPeriodo
            // 
            this.pesPeriodo.Location = new System.Drawing.Point(18, 69);
            this.pesPeriodo.Name = "pesPeriodo";
            this.pesPeriodo.Size = new System.Drawing.Size(124, 20);
            this.pesPeriodo.TabIndex = 8;
            // 
            // pesUnidade
            // 
            this.pesUnidade.Location = new System.Drawing.Point(148, 69);
            this.pesUnidade.Name = "pesUnidade";
            this.pesUnidade.Size = new System.Drawing.Size(124, 20);
            this.pesUnidade.TabIndex = 9;
            // 
            // tbxPSerie
            // 
            this.tbxPSerie.Location = new System.Drawing.Point(210, 25);
            this.tbxPSerie.Name = "tbxPSerie";
            this.tbxPSerie.Size = new System.Drawing.Size(85, 20);
            this.tbxPSerie.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Primeira Série";
            // 
            // tbxUSerie
            // 
            this.tbxUSerie.Location = new System.Drawing.Point(301, 25);
            this.tbxUSerie.Name = "tbxUSerie";
            this.tbxUSerie.Size = new System.Drawing.Size(96, 20);
            this.tbxUSerie.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Última Série";
            // 
            // CriarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 179);
            this.Controls.Add(this.tbxUSerie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxPSerie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pesUnidade);
            this.Controls.Add(this.pesPeriodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxAno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Name = "CriarCurso";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.CriarCurso_Load);
            this.Shown += new System.EventHandler(this.CriarCurso_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.TextBox tbxAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Shared.UCPesquisa pesPeriodo;
        private Shared.UCPesquisa pesUnidade;
        private System.Windows.Forms.TextBox tbxPSerie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxUSerie;
        private System.Windows.Forms.Label label6;
    }
}