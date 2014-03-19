namespace KetClass.View.Alunos
{
    partial class AlunoEdit
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
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.tbxCor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpMatricula = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.ucMae = new KetClass.View.Shared.UCPessoaedit();
            this.ucPai = new KetClass.View.Shared.UCPessoaedit();
            this.ucAluno = new KetClass.View.Shared.UCPessoaedit();
            this.pesUnidade = new KetClass.View.Shared.UCPesquisa();
            this.pesPeriodo = new KetClass.View.Shared.UCPesquisa();
            this.pesAno = new KetClass.View.Shared.UCPesquisa();
            this.pesTurma = new KetClass.View.Shared.UCPesquisa();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(498, 435);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(579, 435);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código Aluno";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(16, 30);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(157, 20);
            this.tbxCodigo.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtFeminino);
            this.groupBox1.Controls.Add(this.rbtMasculino);
            this.groupBox1.Location = new System.Drawing.Point(195, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 37);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(86, 14);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtFeminino.TabIndex = 1;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Checked = true;
            this.rbtMasculino.Location = new System.Drawing.Point(7, 14);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 0;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // tbxCor
            // 
            this.tbxCor.Location = new System.Drawing.Point(358, 30);
            this.tbxCor.Name = "tbxCor";
            this.tbxCor.Size = new System.Drawing.Size(108, 20);
            this.tbxCor.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Unidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Período";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ano";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Turma";
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(579, 393);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(84, 20);
            this.tbxNumero.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Número";
            // 
            // dtpMatricula
            // 
            this.dtpMatricula.CustomFormat = "";
            this.dtpMatricula.Location = new System.Drawing.Point(16, 433);
            this.dtpMatricula.Name = "dtpMatricula";
            this.dtpMatricula.Size = new System.Drawing.Size(217, 20);
            this.dtpMatricula.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Data Matrícula";
            // 
            // ucMae
            // 
            this.ucMae.Location = new System.Drawing.Point(12, 254);
            this.ucMae.Name = "ucMae";
            this.ucMae.Nome = "";
            this.ucMae.Size = new System.Drawing.Size(674, 119);
            this.ucMae.TabIndex = 4;
            // 
            // ucPai
            // 
            this.ucPai.Location = new System.Drawing.Point(12, 150);
            this.ucPai.Name = "ucPai";
            this.ucPai.Nome = "";
            this.ucPai.Size = new System.Drawing.Size(674, 119);
            this.ucPai.TabIndex = 3;
            // 
            // ucAluno
            // 
            this.ucAluno.Location = new System.Drawing.Point(12, 48);
            this.ucAluno.Name = "ucAluno";
            this.ucAluno.Nome = "";
            this.ucAluno.Size = new System.Drawing.Size(674, 114);
            this.ucAluno.TabIndex = 2;
            // 
            // pesUnidade
            // 
            this.pesUnidade.Location = new System.Drawing.Point(16, 393);
            this.pesUnidade.Name = "pesUnidade";
            this.pesUnidade.Size = new System.Drawing.Size(127, 20);
            this.pesUnidade.TabIndex = 22;
            // 
            // pesPeriodo
            // 
            this.pesPeriodo.Location = new System.Drawing.Point(150, 393);
            this.pesPeriodo.Name = "pesPeriodo";
            this.pesPeriodo.Size = new System.Drawing.Size(134, 20);
            this.pesPeriodo.TabIndex = 23;
            // 
            // pesAno
            // 
            this.pesAno.Location = new System.Drawing.Point(291, 393);
            this.pesAno.Name = "pesAno";
            this.pesAno.Size = new System.Drawing.Size(141, 20);
            this.pesAno.TabIndex = 24;
            // 
            // pesTurma
            // 
            this.pesTurma.Location = new System.Drawing.Point(441, 393);
            this.pesTurma.Name = "pesTurma";
            this.pesTurma.Size = new System.Drawing.Size(132, 20);
            this.pesTurma.TabIndex = 25;
            // 
            // AlunoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 470);
            this.Controls.Add(this.pesTurma);
            this.Controls.Add(this.pesAno);
            this.Controls.Add(this.pesPeriodo);
            this.Controls.Add(this.pesUnidade);
            this.Controls.Add(this.dtpMatricula);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxNumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxCor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucMae);
            this.Controls.Add(this.ucPai);
            this.Controls.Add(this.ucAluno);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnGravar);
            this.Name = "AlunoEdit";
            this.Text = "AlunoEdit";
            this.Load += new System.EventHandler(this.AlunoEdit_Load);
            this.Shown += new System.EventHandler(this.AlunoEdit_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnFechar;
        private Shared.UCPessoaedit ucAluno;
        private Shared.UCPessoaedit ucPai;
        private Shared.UCPessoaedit ucMae;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.TextBox tbxCor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpMatricula;
        private System.Windows.Forms.Label label8;
        private Shared.UCPesquisa pesUnidade;
        private Shared.UCPesquisa pesPeriodo;
        private Shared.UCPesquisa pesAno;
        private Shared.UCPesquisa pesTurma;

    }
}