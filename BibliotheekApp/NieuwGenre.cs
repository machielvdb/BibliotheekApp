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
    public partial class NieuwGenre : Form
    {
        public NieuwGenre()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            Genres nieuwGenre = new Genres(tbGenre.Text);

            using (BoekenDBEntities ctx = new BoekenDBEntities())
            {
                ctx.Genres.Add(nieuwGenre);
                ctx.SaveChanges();
                MessageBox.Show("Genre toegevoegd.");
                Close();
            }
        }
    }
}
