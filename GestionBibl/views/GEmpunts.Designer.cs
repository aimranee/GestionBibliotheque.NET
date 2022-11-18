namespace GestionBibl
{
    partial class GEmpunts
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
            this.GEmprunts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GEmprunts
            // 
            this.GEmprunts.AutoSize = true;
            this.GEmprunts.Location = new System.Drawing.Point(596, 266);
            this.GEmprunts.Name = "GEmprunts";
            this.GEmprunts.Size = new System.Drawing.Size(66, 15);
            this.GEmprunts.TabIndex = 0;
            this.GEmprunts.Text = "GEmprunts";
            // 
            // GEmpunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GEmprunts);
            this.Name = "GEmpunts";
            this.Size = new System.Drawing.Size(769, 376);
            this.Load += new System.EventHandler(this.GEmpunts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label GEmprunts;
    }
}
