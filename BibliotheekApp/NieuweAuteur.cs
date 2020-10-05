using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotheekApp
{
    public partial class NieuweAuteur : Form
    {
        public NieuweAuteur()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            Auteurs nieuweAuteur = new Auteurs(tbVoornaam.Text, tbAchternaam.Text);

            using (BoekenDBEntities ctx = new BoekenDBEntities())
            {
                var auteurToevoegen = ctx.Auteurs.Add(nieuweAuteur);
                ctx.SaveChanges();
                MessageBox.Show("Nieuwe auteur opgeslagen.");
                Close();
            }
        }
    }
}