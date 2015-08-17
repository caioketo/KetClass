namespace KetClass.View.Login
{
    partial class CreateRole
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
            this.cbxPermissoes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPermissoes = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissoes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxPermissoes
            // 
            this.cbxPermissoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPermissoes.FormattingEnabled = true;
            this.cbxPermissoes.Location = new System.Drawing.Point(11, 75);
            this.cbxPermissoes.Name = "cbxPermissoes";
            this.cbxPermissoes.Size = new System.Drawing.Size(200, 21);
            this.cbxPermissoes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Permissão";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPermissoes
            // 
            this.dgvPermissoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermissoes.Location = new System.Drawing.Point(12, 103);
            this.dgvPermissoes.Name = "dgvPermissoes";
            this.dgvPermissoes.Size = new System.Drawing.Size(228, 232);
            this.dgvPermissoes.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(11, 25);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(200, 20);
            this.tbxDescricao.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição";
            // 
            // CreateRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 377);
            this.Controls.Add(this.tbxDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvPermissoes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPermissoes);
            this.Name = "CreateRole";
            this.Text = "CreateRole";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPermissoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPermissoes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Label label3;
    }
}