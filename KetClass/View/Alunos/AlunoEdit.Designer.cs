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
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpMatricula = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.ucPai = new KetClass.View.Shared.UCPessoaedit();
            this.ucAluno = new KetClass.View.Shared.UCPessoaedit();
            this.pesTurma = new KetClass.View.Shared.UCPesquisa();
            this.label9 = new System.Windows.Forms.Label();
            this.ucMae = new KetClass.View.Shared.UCPessoaedit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(502, 325);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(583, 325);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 9;
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
            this.tbxCodigo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtFeminino);
            this.groupBox1.Controls.Add(this.rbtMasculino);
            this.groupBox1.Location = new System.Drawing.Point(195, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 37);
            this.groupBox1.TabIndex = 3;
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
            this.rbtMasculino.TabIndex = 1;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(150, 328);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(84, 20);
            this.tbxNumero.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Número";
            // 
            // dtpMatricula
            // 
            this.dtpMatricula.CustomFormat = "";
            this.dtpMatricula.Location = new System.Drawing.Point(240, 328);
            this.dtpMatricula.Name = "dtpMatricula";
            this.dtpMatricula.Size = new System.Drawing.Size(217, 20);
            this.dtpMatricula.TabIndex = 7;
            this.dtpMatricula.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Data Matrícula";
            this.label8.Visible = false;
            // 
            // ucPai
            // 
            this.ucPai.Location = new System.Drawing.Point(3, 168);
            this.ucPai.Name = "ucPai";
            this.ucPai.Nome = "";
            this.ucPai.Size = new System.Drawing.Size(674, 68);
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
            // pesTurma
            // 
            this.pesTurma.Location = new System.Drawing.Point(12, 328);
            this.pesTurma.Name = "pesTurma";
            this.pesTurma.ReadOnly = false;
            this.pesTurma.Size = new System.Drawing.Size(132, 20);
            this.pesTurma.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Turma";
            // 
            // ucMae
            // 
            this.ucMae.Location = new System.Drawing.Point(3, 242);
            this.ucMae.Name = "ucMae";
            this.ucMae.Nome = "";
            this.ucMae.Size = new System.Drawing.Size(674, 66);
            this.ucMae.TabIndex = 27;
            // 
            // AlunoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 356);
            this.Controls.Add(this.ucMae);
            this.Controls.Add(this.pesTurma);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpMatricula);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxNumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucPai);
            this.Controls.Add(this.ucAluno);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnGravar);
            this.KeyPreview = true;
            this.Name = "AlunoEdit";
            this.Text = "AlunoEdit";
            this.Shown += new System.EventHandler(this.AlunoEdit_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlunoEdit_KeyPress);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpMatricula;
        private System.Windows.Forms.Label label8;
        private Shared.UCPesquisa pesTurma;
        private System.Windows.Forms.Label label9;
        private Shared.UCPessoaedit ucMae;

    }
}