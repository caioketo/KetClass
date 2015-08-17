namespace KetClass.View.Login
{
    partial class CreateUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(16, 30);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(179, 20);
            this.tbxLogin.TabIndex = 1;
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(201, 30);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(179, 20);
            this.tbxSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(16, 70);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(179, 20);
            this.tbxNome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome";
            // 
            // tbxCargo
            // 
            this.tbxCargo.Location = new System.Drawing.Point(201, 70);
            this.tbxCargo.Name = "tbxCargo";
            this.tbxCargo.Size = new System.Drawing.Size(179, 20);
            this.tbxCargo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Roles";
            // 
            // cmbRoles
            // 
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(16, 110);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(364, 21);
            this.cmbRoles.TabIndex = 9;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(386, 110);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(21, 21);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "+";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(413, 110);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(21, 21);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "-";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(16, 138);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoles.Size = new System.Drawing.Size(364, 169);
            this.dgvRoles.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 357);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxCargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.label1);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Button button2;
    }
}