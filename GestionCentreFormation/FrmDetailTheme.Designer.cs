namespace GestionCentreFormation
{
    partial class FrmDetailThemeFormation
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
            this.TxtLibeller = new System.Windows.Forms.TextBox();
            this.TxtLibelle = new System.Windows.Forms.Label();
            this.CmdValider = new System.Windows.Forms.Button();
            this.CmdAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtLibeller
            // 
            this.TxtLibeller.Location = new System.Drawing.Point(53, 12);
            this.TxtLibeller.Name = "TxtLibeller";
            this.TxtLibeller.Size = new System.Drawing.Size(166, 20);
            this.TxtLibeller.TabIndex = 0;
            this.TxtLibeller.TextChanged += new System.EventHandler(this.TxtLibeller_TextChanged);
            // 
            // TxtLibelle
            // 
            this.TxtLibelle.AutoSize = true;
            this.TxtLibelle.Location = new System.Drawing.Point(12, 18);
            this.TxtLibelle.Name = "TxtLibelle";
            this.TxtLibelle.Size = new System.Drawing.Size(37, 13);
            this.TxtLibelle.TabIndex = 1;
            this.TxtLibelle.Text = "Libelle";
            this.TxtLibelle.Click += new System.EventHandler(this.TxtLibelle_Click);
            // 
            // CmdValider
            // 
            this.CmdValider.Location = new System.Drawing.Point(53, 38);
            this.CmdValider.Name = "CmdValider";
            this.CmdValider.Size = new System.Drawing.Size(58, 23);
            this.CmdValider.TabIndex = 2;
            this.CmdValider.Text = "Valider";
            this.CmdValider.UseVisualStyleBackColor = true;
            this.CmdValider.Click += new System.EventHandler(this.CmdValider_Click);
            // 
            // CmdAnnuler
            // 
            this.CmdAnnuler.Location = new System.Drawing.Point(161, 38);
            this.CmdAnnuler.Name = "CmdAnnuler";
            this.CmdAnnuler.Size = new System.Drawing.Size(58, 23);
            this.CmdAnnuler.TabIndex = 3;
            this.CmdAnnuler.Text = "Annuler";
            this.CmdAnnuler.UseVisualStyleBackColor = true;
            this.CmdAnnuler.Click += new System.EventHandler(this.CmdAnnuler_Click);
            // 
            // FrmDetailThemeFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 77);
            this.Controls.Add(this.CmdAnnuler);
            this.Controls.Add(this.CmdValider);
            this.Controls.Add(this.TxtLibelle);
            this.Controls.Add(this.TxtLibeller);
            this.Name = "FrmDetailThemeFormation";
            this.Text = "FrmDetailThemeFormation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TxtLibelle;
        private System.Windows.Forms.Button CmdValider;
        private System.Windows.Forms.Button CmdAnnuler;
        internal System.Windows.Forms.TextBox TxtLibeller;
    }
}