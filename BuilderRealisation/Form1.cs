using System;
using AirPlaneCore;
using System.Windows.Forms;

namespace BuilderRealisation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var builder = new AirPlaneBuilder();

            var director = new AirPlaneDirector(builder);

            director.Build(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));

            var airPlane = builder.GetAirPlane();

            richTextBox1.Text = airPlane.ToString();
        }
    }
}
