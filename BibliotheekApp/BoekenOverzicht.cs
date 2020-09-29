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
            FillListBox();
            JoinQuery();
        }

        private void lbBoeken_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (BoekenDBEntities ctx = new BoekenDBEntities())
            {
                var geselecteerdBoekTemp = lbBoeken.SelectedItem as Boeken;
                var geselecteerdBoek = ctx.Boeken.Select(x => x == geselecteerdBoekTemp);

            }
        }
        public void JoinQuery()
        {
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
            }
        }


        private void FillListBox()
        {
            using (BoekenDBEntities ctx = new BoekenDBEntities())
            {
                var boekenLijst = ctx.Boeken.Select(x => x).ToList();
                lbBoeken.DisplayMember = "Titel";
                lbBoeken.ValueMember = "Id";
                lbBoeken.DataSource = null;
                lbBoeken.DataSource = boekenLijst;
            }
        }
    }
}
