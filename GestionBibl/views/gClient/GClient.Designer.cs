namespace GestionBibl.views
{
    partial class GClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GClient));
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCIN = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSrch = new System.Windows.Forms.TextBox();
            this.pictureBox_Rechercher = new System.Windows.Forms.PictureBox();
            this.pictureBox_supprimer = new System.Windows.Forms.PictureBox();
            this.pictureBox_Modifier = new System.Windows.Forms.PictureBox();
            this.pictureBox_Ajouter = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Rechercher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_supprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Modifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ajouter)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Location = new System.Drawing.Point(35, 74);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(156, 16);
            this.txtNom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(91, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(262, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrenom.Location = new System.Drawing.Point(212, 74);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(156, 16);
            this.txtPrenom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(458, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "CIN";
            // 
            // txtCIN
            // 
            this.txtCIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCIN.Location = new System.Drawing.Point(394, 74);
            this.txtCIN.Name = "txtCIN";
            this.txtCIN.Size = new System.Drawing.Size(156, 16);
            this.txtCIN.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(35, 188);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(696, 172);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(374, 160);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(156, 23);
            this.txtId.TabIndex = 9;
            this.txtId.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(625, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Statut";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bloquer",
            "Debloquer"});
            this.comboBox1.Location = new System.Drawing.Point(575, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 23);
            this.comboBox1.TabIndex = 12;
            // 
            // txtSrch
            // 
            this.txtSrch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSrch.Location = new System.Drawing.Point(536, 160);
            this.txtSrch.Name = "txtSrch";
            this.txtSrch.Size = new System.Drawing.Size(156, 16);
            this.txtSrch.TabIndex = 14;
            // 
            // pictureBox_Rechercher
            // 
            this.pictureBox_Rechercher.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Rechercher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Rechercher.BackgroundImage")));
            this.pictureBox_Rechercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Rechercher.Location = new System.Drawing.Point(697, 154);
            this.pictureBox_Rechercher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Rechercher.Name = "pictureBox_Rechercher";
            this.pictureBox_Rechercher.Size = new System.Drawing.Size(33, 29);
            this.pictureBox_Rechercher.TabIndex = 16;
            this.pictureBox_Rechercher.TabStop = false;
            this.pictureBox_Rechercher.Click += new System.EventHandler(this.pictureBox_Rechercher_Click);
            // 
            // pictureBox_supprimer
            // 
            this.pictureBox_supprimer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_supprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_supprimer.BackgroundImage")));
            this.pictureBox_supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_supprimer.Location = new System.Drawing.Point(421, 112);
            this.pictureBox_supprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_supprimer.Name = "pictureBox_supprimer";
            this.pictureBox_supprimer.Size = new System.Drawing.Size(33, 29);
            this.pictureBox_supprimer.TabIndex = 17;
            this.pictureBox_supprimer.TabStop = false;
            this.pictureBox_supprimer.Click += new System.EventHandler(this.pictureBox_supprimer_Click);
            // 
            // pictureBox_Modifier
            // 
            this.pictureBox_Modifier.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Modifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Modifier.BackgroundImage")));
            this.pictureBox_Modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Modifier.Location = new System.Drawing.Point(374, 112);
            this.pictureBox_Modifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Modifier.Name = "pictureBox_Modifier";
            this.pictureBox_Modifier.Size = new System.Drawing.Size(33, 29);
            this.pictureBox_Modifier.TabIndex = 18;
            this.pictureBox_Modifier.TabStop = false;
            this.pictureBox_Modifier.Click += new System.EventHandler(this.pictureBox_Modifier_Click);
            // 
            // pictureBox_Ajouter
            // 
            this.pictureBox_Ajouter.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Ajouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Ajouter.BackgroundImage")));
            this.pictureBox_Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Ajouter.Location = new System.Drawing.Point(328, 112);
            this.pictureBox_Ajouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Ajouter.Name = "pictureBox_Ajouter";
            this.pictureBox_Ajouter.Size = new System.Drawing.Size(33, 29);
            this.pictureBox_Ajouter.TabIndex = 19;
            this.pictureBox_Ajouter.TabStop = false;
            this.pictureBox_Ajouter.Click += new System.EventHandler(this.pictureBox_Ajouter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(576, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 1);
            this.panel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(36, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 1);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(213, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 1);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(395, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 1);
            this.panel4.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(536, 179);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(155, 1);
            this.panel5.TabIndex = 23;
            // 
            // GClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_Ajouter);
            this.Controls.Add(this.pictureBox_Modifier);
            this.Controls.Add(this.pictureBox_supprimer);
            this.Controls.Add(this.pictureBox_Rechercher);
            this.Controls.Add(this.txtSrch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom);
            this.Name = "GClient";
            this.Size = new System.Drawing.Size(769, 376);
            this.Load += new System.EventHandler(this.GClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Rechercher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_supprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Modifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ajouter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNom;
        private Label label1;
        private Label label2;
        private TextBox txtPrenom;
        private Label label3;
        private TextBox txtCIN;
        private DataGridView dataGridView;
        private TextBox txtId;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox txtSrch;
        private PictureBox pictureBox_Rechercher;
        private PictureBox pictureBox_supprimer;
        private PictureBox pictureBox_Modifier;
        private PictureBox pictureBox_Ajouter;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}
