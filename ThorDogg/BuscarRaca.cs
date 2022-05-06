using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThorDogg
{
    public partial class BuscarRaca : Form
    {
        private ApiTheDog Doggos;
        public BuscarRaca()
        {
            InitializeComponent();
            Doggos = new ApiTheDog();
        }

        private void BuscarRaca_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 inicial = new Form1();
            inicial.Show();
        }

        private void labelSubtexto_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregaResultado(Doggos.GetCaracteristicas());
        }
        private void CarregaResultado(DoggModel Resultado)
        {
            try
            {
                labelRacaNome.Text = Resultado.Breeds[0].name;
                labelResDescricao.Text = Resultado.Breeds[0].bredfor;
                labelResVida.Text = Resultado.Breeds[0].lifespan;
                labelResTemperamento.Text = Resultado.Breeds[0].temperament;
                pictureDogg.Load(Resultado.url);
            }
            catch (IndexOutOfRangeException)
            {
                CarregaResultado(Doggos.GetCaracteristicas());
            }
        }
        private void pictureDogg_Click(object sender, EventArgs e)
        {
           
        }
        private void labelResTemperamento_Click(object sender, EventArgs e)
        {

        }

        private void cbSelecRaca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSurprise_Click(object sender, EventArgs e)
        {
            labelRacaNome.Text = "Semi-deus. Seu nome é Thor!";
            labelResDescricao.Text = "Ser amigável, companheiro e que traz a felicidade da minha dona.";
            labelResVida.Text = "Poderia ser infinito.";
            labelResTemperamento.Text = "Gosta de brincar, é esperto e bagunça às vezes.";
            pictureDogg.Load("https://i.ibb.co/zGRH27S/f1a80367-612e-4ada-9dbd-e52238ac5217.jpg");
        }

        private void labelRacaNome_Click(object sender, EventArgs e)
        {

        }
    }
}
