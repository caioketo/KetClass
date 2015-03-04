namespace KetClass.View.Matriculas
{
    partial class MatriculaView
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
            this.crud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crud.Location = new System.Drawing.Point(-1, 0);
            this.crud.Name = "crud";
            this.crud.Size = new System.Drawing.Size(832, 469);
            this.crud.TabIndex = 1;
            // 
            // MatriculaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 470);
            this.Controls.Add(this.crud);
            this.Name = "MatriculaView";
            this.Text = "MatriculaView";
            this.ResumeLayout(false);

        }

        #endregion

        private Shared.UCCRUD crud;
    }
}