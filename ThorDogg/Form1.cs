namespace ThorDogg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRacas_Click(object sender, EventArgs e)
        {
            BuscarRaca buscarRaca = new BuscarRaca();
            buscarRaca.Show();
            this.Hide();
        }
    }
}