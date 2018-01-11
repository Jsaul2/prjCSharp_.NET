namespace GestionCentreFormation
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LstFormations = new System.Windows.Forms.DataGridView();
            this.CmdAjouter = new System.Windows.Forms.Button();
            this.CmdModifier = new System.Windows.Forms.Button();
            this.CmdSupprimer = new System.Windows.Forms.Button();
            this.CmdSupprimerLot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LstFormations)).BeginInit();
            this.SuspendLayout();
            // 
            // LstFormations
            // 
            this.LstFormations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LstFormations.Location = new System.Drawing.Point(13, 13);
            this.LstFormations.Name = "LstFormations";
            this.LstFormations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LstFormations.Size = new System.Drawing.Size(878, 225);
            this.LstFormations.TabIndex = 0;
            this.LstFormations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LstFormations_CellContentClick);
            // 
            // CmdAjouter
            // 
            this.CmdAjouter.Location = new System.Drawing.Point(281, 244);
            this.CmdAjouter.Name = "CmdAjouter";
            this.CmdAjouter.Size = new System.Drawing.Size(75, 23);
            this.CmdAjouter.TabIndex = 1;
            this.CmdAjouter.Text = "Ajouter";
            this.CmdAjouter.UseVisualStyleBackColor = true;
            this.CmdAjouter.Click += new System.EventHandler(this.CmdAjouter_Click);
            // 
            // CmdModifier
            // 
            this.CmdModifier.Location = new System.Drawing.Point(362, 244);
            this.CmdModifier.Name = "CmdModifier";
            this.CmdModifier.Size = new System.Drawing.Size(75, 23);
            this.CmdModifier.TabIndex = 2;
            this.CmdModifier.Text = "Modifier";
            this.CmdModifier.UseVisualStyleBackColor = true;
            this.CmdModifier.Click += new System.EventHandler(this.CmdModifier_Click);
            // 
            // CmdSupprimer
            // 
            this.CmdSupprimer.Location = new System.Drawing.Point(443, 244);
            this.CmdSupprimer.Name = "CmdSupprimer";
            this.CmdSupprimer.Size = new System.Drawing.Size(75, 23);
            this.CmdSupprimer.TabIndex = 3;
            this.CmdSupprimer.Text = "Supprimer";
            this.CmdSupprimer.UseVisualStyleBackColor = true;
            this.CmdSupprimer.Click += new System.EventHandler(this.CmdSupprimer_Click);
            // 
            // CmdSupprimerLot
            // 
            this.CmdSupprimerLot.Location = new System.Drawing.Point(524, 244);
            this.CmdSupprimerLot.Name = "CmdSupprimerLot";
            this.CmdSupprimerLot.Size = new System.Drawing.Size(78, 23);
            this.CmdSupprimerLot.TabIndex = 4;
            this.CmdSupprimerLot.Text = "SupprimerLot";
            this.CmdSupprimerLot.UseVisualStyleBackColor = true;
            this.CmdSupprimerLot.Click += new System.EventHandler(this.CmdSupprimerLot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 277);
            this.Controls.Add(this.CmdSupprimerLot);
            this.Controls.Add(this.CmdSupprimer);
            this.Controls.Add(this.CmdModifier);
            this.Controls.Add(this.CmdAjouter);
            this.Controls.Add(this.LstFormations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LstFormations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LstFormations;
        private System.Windows.Forms.Button CmdAjouter;
        private System.Windows.Forms.Button CmdModifier;
        private System.Windows.Forms.Button CmdSupprimer;
        private System.Windows.Forms.Button CmdSupprimerLot;
    }
}

