using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThorDogg
{
    public partial class Favoritos : Form
    {
        public Favoritos()
        {
            InitializeComponent();
        }

        private void textRacas_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void btnDesfavoritar_Click(object sender, EventArgs e)
        {

        }

        private void listaFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
