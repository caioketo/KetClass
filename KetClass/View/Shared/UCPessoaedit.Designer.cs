namespace KetClass.View.Shared
{
    partial class UCPessoaedit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxGeral = new System.Windows.Forms.GroupBox();
            this.tbxRG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxTelefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxGeral
            // 
            this.gbxGeral.Controls.Add(this.tbxCPF);
            this.gbxGeral.Controls.Add(this.label3);
            this.gbxGeral.Controls.Add(this.tbxRG);
            this.gbxGeral.Controls.Add(this.label8);
            this.gbxGeral.Controls.Add(this.dtpNascimento);
            this.gbxGeral.Controls.Add(this.label7);
            this.gbxGeral.Controls.Add(this.tbxTelefone);
            this.gbxGeral.Controls.Add(this.label2);
            this.gbxGeral.Controls.Add(this.tbxNome);
            this.gbxGeral.Controls.Add(this.label1);
            this.gbxGeral.Location = new System.Drawing.Point(3, 3);
            this.gbxGeral.Name = "gbxGeral";
            this.gbxGeral.Size = new System.Drawing.Size(634, 110);
            this.gbxGeral.TabIndex = 3;
            this.gbxGeral.TabStop = false;
            // 
            // tbxRG
            // 
            this.tbxRG.Location = new System.Drawing.Point(322, 36);
            this.tbxRG.Name = "tbxRG";
            this.tbxRG.Size = new System.Drawing.Size(129, 20);
            this.tbxRG.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "RG";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CustomFormat = "";
            this.dtpNascimento.Location = new System.Drawing.Point(10, 77);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(228, 20);
            this.dtpNascimento.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Data Nascimento";
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.Location = new System.Drawing.Point(244, 77);
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(123, 20);
            this.tbxTelefone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(10, 37);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(306, 20);
            this.tbxNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tbxCPF
            // 
            this.tbxCPF.Location = new System.Drawing.Point(457, 36);
            this.tbxCPF.Name = "tbxCPF";
            this.tbxCPF.Size = new System.Drawing.Size(170, 20);
            this.tbxCPF.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF";
            // 
            // UCPessoaedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxGeral);
            this.Name = "UCPessoaedit";
            this.Size = new System.Drawing.Size(642, 119);
            this.gbxGeral.ResumeLayout(false);
            this.gbxGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGeral;
        private System.Windows.Forms.TextBox tbxCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxRG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label1;
    }
}
