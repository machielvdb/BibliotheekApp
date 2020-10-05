using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotheekApp
{
    public partial class NieuwBoek : Form
    {
        private List<Genres> _genreLijst = new List<Genres>();
        private List<Auteurs> _auteurLijst = new List<Auteurs>();
        public NieuwBoek()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void NieuwBoek_Load(object sender, EventArgs e)
        {
            FillBoxes();
        }

        public NieuwBoek(Boeken geselecteerdBoek)
        {
            InitializeComponent();
            CenterToScreen();
            BoekAanpassen(geselecteerdBoek);
        }

        private void GetGenres(Boeken geselecteerdBoek)
        {
            using (BoekenDBEntities ctx = new BoekenDBEntities())
            {
                var genreIdQuery = ctx.BoekenGenres.Where(x => x.BoekId == geselecteerdBoek.Id).Select(x => x.GenreId).ToList();

                foreach (var item in genreIdQuery)
                {
                    _genreLijst.Add(ctx.Genres.Where(x => x.Id == item).Select(x => x).FirstOrDefault());
                }

                lbGenres.DisplayMember = "Genre";
                lbGenres.DataSource = null;
                lbGenres.DataSource = _genreLijst;
            }
        }

        private void GetAuteurs(Boeken geselecteerdBoek)
        {
            using (BoekenDBEntities ctx = new BoekenDBEntities())
            {
                var auteurIdQuery = ctx.BoekenAuteurs.Where(x => x.BoekId == geselecteerdBoek.Id).Select(x => x.AuteurId).ToList();

                foreach (var item in auteurIdQuery)
                {
                    _auteurLijst.Add(ctx.Auteurs.Where(x => x.Id == item).Select(x => x).FirstOrDefault());
                }

                lbAuteurs.DataSource = null;
                lbAuteurs.DataSource = _auteurLijst;
            }
        }

        private void BoekAanpassen(Boeken geselecteerdBoek)
        {
            FillBoxes();
            tbTitel.Text = geselecteerdBoek.Titel;
            tbScore.Text = geselecteerdBoek.Score.ToString();
            tbPaginas.Text = geselecteerdBoek.AantalPaginas.ToString();
            GetGenres(geselecteerdBoek);
            GetAuteurs(geselecteerdBoek);
        }

        private void FillBoxes()
        {
            // Lijsten met objecten ophalen uit DB en linken aan comboboxes.
            using (BoekenDBEntities ctx = new BoekenDBEntities())
            {
                var auteurLijst = ctx.Auteurs.Select(x => x).ToList();
                var genreLijst = ctx.Genres.Select(x => x).ToList();
                var uitgeverLijst = ctx.Uitgeverijen.Select(x => x).ToList();

                cbAuteur.DataSource = null;
                cbAuteur.DataSource = auteurLijst;

                cbUitgever.DataSource = null;
                cbUitgever.DataSource = uitgeverLijst;

                cbGenre.DataSource = null;
                cbGenre.DataSource = genreLijst;
            }
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            // Maak nieuw boekobject aan en sla op in database.
            Boeken nieuwBoek = new Boeken();
            var uitgever = (Uitgeverijen)cbUitgever.SelectedItem;
            nieuwBoek.Titel = tbTitel.Text;
            nieuwBoek.Score = int.Parse(tbScore.Text);
            nieuwBoek.UitgeverId = uitgever.Id;
            nieuwBoek.AantalPaginas = int.Parse(tbPaginas.Text);
            nieuwBoek.Publicatie = "Paperback";

            using (BoekenDBEntities ctx = new BoekenDBEntities())
            {
                var boekToevoegen = ctx.Boeken.Add(nieuwBoek);
                ctx.SaveChanges();

                // Link de genres.
                foreach (var item in _genreLijst)
                {
                    BoekenGenres newBg = new BoekenGenres(boekToevoegen.Id, item.Id);
                    ctx.BoekenGenres.Add(newBg);
                }

                // Link de auteurs.
                foreach (var item in _auteurLijst)
                {
                    BoekenAuteurs newBa = new BoekenAuteurs(boekToevoegen.Id, item.Id);
                    ctx.BoekenAuteurs.Add(newBa);
                }

                ctx.SaveChanges();
            }

            MessageBox.Show("Boek toegevoegd.");
            Close();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            // Genre toevoegen als deze niet reeds is toegevoegd.
            if (!_genreLijst.Contains((Genres)cbGenre.SelectedItem))
            {
                _genreLijst.Add((Genres)cbGenre.SelectedItem);
                lbGenres.DataSource = null;
                lbGenres.DataSource = _genreLijst;
            }
        }

        private void btnAddAuteur_Click(object sender, EventArgs e)
        {
            // Auteur toevoegen als deze niet reeds is toegevoegd.
            if (!_auteurLijst.Contains((Auteurs)cbAuteur.SelectedItem))
            {
                _auteurLijst.Add((Auteurs)cbAuteur.SelectedItem);
                lbAuteurs.DataSource = null;
                lbAuteurs.DataSource = _auteurLijst;
            }
        }

        private void btnVerwijderGenre_Click(object sender, EventArgs e)
        {
            Genres verwijderGenre = lbGenres.SelectedItem as Genres;

            foreach (var item in _genreLijst)
            {
                if (item == verwijderGenre)
                {
                    _genreLijst.Remove(item);
                }
            }
        }

        private void btnVerwijderAuteur_Click(object sender, EventArgs e)
        {
            Auteurs verwijderAuteur = lbAuteurs.SelectedItem as Auteurs;

            foreach (var item in _auteurLijst)
            {
                if (item == verwijderAuteur)
                {
                    _auteurLijst.Remove(item);
                }
            }
        }
    }
}
