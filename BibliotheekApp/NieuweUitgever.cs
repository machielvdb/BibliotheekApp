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
    public partial class NieuweUitgever : Form
    {
        public NieuweUitgever()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            Uitgeverijen nieuweUitgever = new Uitgeverijen(tbNaam.Text);

            using (BoekenDBEntities ctx = new BoekenDBEntities())
            {
                ctx.Uitgeverijen.Add(nieuweUitgever);
                ctx.SaveChanges();
                MessageBox.Show("Uitgever toegevoegd.");
                Close();
            }
        }
    }
}
