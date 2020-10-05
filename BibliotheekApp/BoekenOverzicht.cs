using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotheekApp
{
    public partial class BoekenOverzicht : Form
    {
        public BoekenOverzicht()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void BoekenOverzicht_Load(object sender, EventArgs e)
        {
            FillBoxes();
        }

        private void lbBoeken_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boeken geselecteerdBoek = lbBoeken.SelectedItem as Boeken;

            using (BoekenDBEntities ctx = new BoekenDBEntities())
            {
                var boekenAuteursQuery = ctx.Boeken
                    .Join(ctx.BoekenAuteurs,
                    b => b.Id,
                    ba => ba.BoekId,
                    (b, ba) => new { b, ba })
                    .Join(ctx.Auteurs,
                    ba2 => ba2.ba.AuteurId,
                    a => a.Id,
                    (ba2, a) => new { ba2, a }).ToList();

                var boekenGenresQuery = ctx.Boeken
                    .Join(ctx.BoekenGenres,
                    b => b.Id,
                    bg => bg.BoekId,
                    (b, bg) => new { b, bg })
                    .Join(ctx.Genres,
                    bg2 => bg2.bg.GenreId,
                    g => g.Id,
                    (bg2, g) => new { bg2, g }).ToList();

                var uitgeverQuery = ctx.Boeken
                    .Join(ctx.Uitgeverijen,
                    b => b.UitgeverId,
                    u => u.Id,
                    (b, u) => new { b, u }).ToList();

                lblTitel.Text = geselecteerdBoek.Titel;
                lblUitgever.Text = uitgeverQuery.Where(x => x.b.Id == geselecteerdBoek.Id).Select(x => x.u.Naam).FirstOrDefault();
                lblPaginas.Text = geselecteerdBoek.AantalPaginas.ToString();
                lblScore.Text = geselecteerdBoek.Score.ToString();

                var genreLijst = boekenGenresQuery.Where(x => x.bg2.b.Id == geselecteerdBoek.Id).Select(x => x.g).ToList();
                lbGenres.DisplayMember = "Genre";
                lbGenres.DataSource = null;
                lbGenres.DataSource = genreLijst;

                var auteurLijst = boekenAuteursQuery.Where(x => x.ba2.b.Id == geselecteerdBoek.Id).Select(x => x.a).ToList();
                lbAuteurs.DataSource = null;
                lbAuteurs.DataSource = auteurLijst;
            }
        }
        private void FillBoxes()
        {
            using (BoekenDBEntities ctx = new BoekenDBEntities())
            {
                var boekenLijst = ctx.Boeken.Select(x => x).ToList();
                lbBoeken.DataSource = null;
                lbBoeken.DataSource = boekenLijst;

                var genreLijst = ctx.Genres.Select(x => x).ToList();
                cbFilter.DataSource = null;
                cbFilter.DataSource = genreLijst;

                var auteurLijst = ctx.Auteurs.Select(x => x).ToList();
                cbFilterParam.DataSource = null;
                cbFilterParam.DataSource = auteurLijst;
            }
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            Boeken geselecteerdBoek = lbBoeken.SelectedItem as Boeken;
            Form f = new NieuwBoek(geselecteerdBoek);
            f.Show();
        }
    }
}
