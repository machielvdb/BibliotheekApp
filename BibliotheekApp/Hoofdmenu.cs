using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotheekApp
{
    public partial class Hoofdmenu : Form
    {
        public Hoofdmenu()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Hoofdmenu_Load(object sender, EventArgs e)
        {

        }

        private void btnBoekenOverzicht_Click(object sender, EventArgs e)
        {
            Form f = new BoekenOverzicht();
            f.Show();
        }
    }
}
