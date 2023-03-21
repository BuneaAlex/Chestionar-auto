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
    public partial class Form2 : Form
    {
        int ok = 0;
        string nume, prenume;
        public static string Nume, Prenume;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nume = textBox2.Text;
            prenume = textBox3.Text;
            if (nume != "" && prenume != "")
                ok = 1;
            if(ok==1)
            {
                Nume = nume;
                Prenume = prenume;
                Form3 f = new Form3();
                this.Hide();
                f.ShowDialog();
                this.Show();
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                Form6 f = new Form6();
                f.ShowDialog();
                this.Show();
            }
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
