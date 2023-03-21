using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_atestat
{
    public partial class Form4 : Form
    {
        int c=Form3.C;
        string n, p;
        public Form4()
        {
            InitializeComponent();
            label2.Text = Convert.ToString(c)+"/15";
            n = Form2.Nume;
            p = Form2.Prenume;
            if (c >= 12)
            {
                textBox1.Text = "Ați fost admis! Felicitări, "+n+" "+p+"!";
                button1.Visible = false;
            }
            else
                textBox1.Text = "Ați fost respins! Mai mult noroc data viitoare!";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f= new Form7();
            this.Close();
            f.ShowDialog();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
