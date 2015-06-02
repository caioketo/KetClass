namespace KetClass.View.Licao
{
    partial class LicaoView
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
            this.crud = new KetClass.View.Shared.UCCRUD();
            this.SuspendLayout();
            // 
            // crud
            // 
            this.crud.Location = new System.Drawing.Point(0, 0);
            this.crud.Name = "crud";
            this.crud.Size = new System.Drawing.Size(689, 445);
            this.crud.TabIndex = 1;
            this.crud.Load += new System.EventHandler(this.crud_Load);
            // 
            // LicaoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 444);
            this.Controls.Add(this.crud);
            this.Name = "LicaoView";
            this.Text = "LicaoView";
            this.ResumeLayout(false);

        }

        #endregion

        private Shared.UCCRUD crud;
    }
}