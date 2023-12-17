using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kur
{
    public partial class Glav : Form
    {
        public Glav()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Clients Clients;
        private void button1_Click(object sender, EventArgs e)
        {
            Clients = new Clients ();
            Clients.Visible = true;
        }
       // private Ar1 arxif;
        private void button4_Click(object sender, EventArgs e)
        {
            //arxif = new Ar1();
            //arxif.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private Nomer Nomers;
        private void button2_Click(object sender, EventArgs e)
        {
            Nomers = new Nomer ();
            Nomers.Visible = true;

            

        }
        private person Personal;
        private void button3_Click(object sender, EventArgs e)
        {
            Personal = new person();
            Personal.Visible = true;

        }
        private Den Dni;
        private void button4_Click_1(object sender, EventArgs e)
        {
            Dni = new Den();
            Dni.Visible = true;
        }
        private Ch Che;
        private void button5_Click(object sender, EventArgs e)
        {
            Che = new Ch();
            Che.Visible = true;

        }
    }
}
