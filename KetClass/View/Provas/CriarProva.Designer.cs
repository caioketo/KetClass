namespace KetClass.View.Provas
{
    partial class CriarProva
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxConteudo = new System.Windows.Forms.TextBox();
            this.cbxDisciplina = new System.Windows.Forms.ComboBox();
            this.cbxTurma = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cbxRec = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(178, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 95);
            this.listBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxConteudo
            // 
            this.tbxConteudo.Location = new System.Drawing.Point(15, 166);
            this.tbxConteudo.Multiline = true;
            this.tbxConteudo.Name = "tbxConteudo";
            this.tbxConteudo.Size = new System.Drawing.Size(506, 218);
            this.tbxConteudo.TabIndex = 17;
            // 
            // cbxDisciplina
            // 
            this.cbxDisciplina.FormattingEnabled = true;
            this.cbxDisciplina.Location = new System.Drawing.Point(15, 68);
            this.cbxDisciplina.Name = "cbxDisciplina";
            this.cbxDisciplina.Size = new System.Drawing.Size(144, 21);
            this.cbxDisciplina.TabIndex = 16;
            // 
            // cbxTurma
            // 
            this.cbxTurma.FormattingEnabled = true;
            this.cbxTurma.Location = new System.Drawing.Point(178, 25);
            this.cbxTurma.Name = "cbxTurma";
            this.cbxTurma.Size = new System.Drawing.Size(142, 21);
            this.cbxTurma.TabIndex = 15;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(15, 26);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(144, 20);
            this.dtpData.TabIndex = 14;
            this.dtpData.Value = new System.DateTime(2014, 8, 20, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Conteúdo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Disciplina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Turma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data da Lição";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 21);
            this.button3.TabIndex = 20;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(355, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 21);
            this.button4.TabIndex = 21;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbxRec
            // 
            this.cbxRec.AutoSize = true;
            this.cbxRec.Location = new System.Drawing.Point(15, 109);
            this.cbxRec.Name = "cbxRec";
            this.cbxRec.Size = new System.Drawing.Size(91, 17);
            this.cbxRec.TabIndex = 22;
            this.cbxRec.Text = "Recuperação";
            this.cbxRec.UseVisualStyleBackColor = true;
            // 
            // CriarProva
            // 
            this.ClientSize = new System.Drawing.Size(542, 457);
            this.Controls.Add(this.cbxRec);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxConteudo);
            this.Controls.Add(this.cbxDisciplina);
            this.Controls.Add(this.cbxTurma);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "CriarProva";
            this.Text = "Criar Prova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxConteudo;
        private System.Windows.Forms.ComboBox cbxDisciplina;
        private System.Windows.Forms.ComboBox cbxTurma;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox cbxRec;
    }
}