namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10; 
                Point currentLocation = pictureBox1.Location;
                pictureBox1.Location = new Point(currentLocation.X += 35, currentLocation.Y);

            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                pictureBox3.Visible = false;
                this.Hide();
                Calculadora form2 = new Calculadora();
                form2.Show();

            }
        }
    }
}
