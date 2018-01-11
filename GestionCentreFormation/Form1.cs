using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCentreFormation
{
    public partial class Form1 : Form
    {
        private FormationEntities ContexteDonnees;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.ContexteDonnees = new FormationEntities();
                LstFormations.DataSource = this.ContexteDonnees.Theme.ToList();
            }
            catch (Exception aEx)
            {
                MessageBox.Show(aEx.Message);
            }
        }

        private void LstFormations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CmdAjouter_Click(object sender, EventArgs e)
        {
            FrmDetailThemeFormation oFrmDetailThemeFormation;
            DialogResult oResult;
            Theme oTheme;

            try
            {
                oFrmDetailThemeFormation = new FrmDetailThemeFormation();
                oResult = oFrmDetailThemeFormation.ShowDialog();

                if (oResult == DialogResult.OK)
                {
                    oTheme = new Theme { Libelle = oFrmDetailThemeFormation.TxtLibeller.Text };

                    this.ContexteDonnees.Theme.Add(oTheme);
                    this.ContexteDonnees.SaveChanges();

                    LstFormations.DataSource = this.ContexteDonnees.Theme.ToList();
                }
            }
            catch (Exception aEx)
            {
                MessageBox.Show(aEx.Message);
            }
        }

        private void CmdModifier_Click(object sender, EventArgs e)
        {
            FrmDetailThemeFormation oFrmDetailThemeFormation;
            DialogResult oResult;
            Theme oTheme;

            try
            {
                oTheme = (Theme)LstFormations.CurrentRow.DataBoundItem;

                if (oTheme != null)
                {
                    oFrmDetailThemeFormation = new FrmDetailThemeFormation(oTheme);
                    //oFrmDetailThemeFormation.TxtLibeller.Text = oTheme.Libelle;
                    oResult = oFrmDetailThemeFormation.ShowDialog();

                    if (oResult == DialogResult.OK)
                    {
                        oTheme.Libelle = oFrmDetailThemeFormation.TxtLibeller.Text;
                        this.ContexteDonnees.SaveChanges();

                        LstFormations.DataSource = this.ContexteDonnees.Theme.ToList();
                    }
                }

            }
            catch (Exception aEx)
            {
                MessageBox.Show(aEx.Message);
            }
        }

        private void CmdSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult oResult;
            Theme oTheme;

            try
            {
                oTheme = (Theme)LstFormations.CurrentRow.DataBoundItem;

                if (oTheme != null)
                {
                    oResult = MessageBox.Show("Confirmer ?", "Demande de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (oResult == DialogResult.Yes)
                    {
                        this.ContexteDonnees.Theme.Remove(oTheme);
                        this.ContexteDonnees.SaveChanges();

                        LstFormations.DataSource = this.ContexteDonnees.Theme.ToList();
                    }
                }

            }
            catch (Exception aEx)
            {
                MessageBox.Show(aEx.Message);
            }
        }

        private void CmdSupprimerLot_Click(object sender, EventArgs e)
        {
            DialogResult oResult;
            List<Theme> oListeTheme;
            DataGridViewSelectedRowCollection oLignesSelectionnees;

            try
            {
                oListeTheme = new List<Theme>();
                oLignesSelectionnees = LstFormations.SelectedRows;
                foreach (DataGridViewRow oDataGridViewRow in oLignesSelectionnees)
                {
                    oListeTheme.Add((Theme)oDataGridViewRow.DataBoundItem);
                }

                if (oListeTheme.Count > 0)
                {
                    oResult = MessageBox.Show("Confirmer ?", "Demande de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (oResult == DialogResult.Yes)
                    {
                        this.ContexteDonnees.Theme.RemoveRange(oListeTheme);
                        this.ContexteDonnees.SaveChanges();

                        LstFormations.DataSource = this.ContexteDonnees.Theme.ToList();
                    }
                }
            }
            catch (Exception aEx)
            {
                MessageBox.Show(aEx.Message);
            }
        }
    }
}
