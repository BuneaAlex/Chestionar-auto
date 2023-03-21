using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_atestat
{
    public partial class Form3 : Form
    {
        int n = 20, m = 0,intrb=15;
        int b,corecte=0,gresite=0,ramase;
        int nr_crt = 1;
        int[] rasp;
        int[]raspuns = { 0, 1, 1, 2, 1, 3, 2, 3, 2, 1, 3, 2, 3, 1, 2, 2, 2, 2, 1, 2, 1, 1, 2, 3, 1, 2, 2, 1, 1, 3, 1 };
        int[] ct;
        int[] v;
        int j = 1;
        string[] q;
        string[] var1;
        string[] var2;
        string[] var3;
        Grila[] data;
        public static int C;
        public Form3()
        {
            InitializeComponent();
            StreamReader sr1 = new StreamReader(@"intrebari.txt");
            StreamReader sr2 = new StreamReader(@"var1.txt");
            StreamReader sr3 = new StreamReader(@"var2.txt");
            StreamReader sr4 = new StreamReader(@"var3.txt");
            timer1.Enabled = true;
            ramase = intrb;
            ct = new int[31];
            v = new int[31];
            rasp = new int[31];
            q = new string[31];
            var1 = new string[31];
            var2 = new string[31];
            var3 = new string[31];
            data = new Grila[41];
            for (int i = 1; i <= 30; i++)
            {
                ct[i] = 0;
                v[i] = 0;
            }
                
            for(int i=1;i<=30;i++)
            {
                string itr = sr1.ReadLine();
                string v1 = sr2.ReadLine();
                string v2 = sr3.ReadLine();
                string v3 = sr4.ReadLine();
                data[i] = new Grila(itr,v1,v2,v3,raspuns[i]);
            }
            Random random = new Random();
            while(j<=intrb)
            {
                int r = random.Next(1, 31);
                if(v[r]==0)
                {
                    v[r] = 1;
                    q[j] = data[r].Intrebare;
                    var1[j] = data[r].Opt1;
                    var2[j] = data[r].Opt2;
                    var3[j] = data[r].Opt3;
                    rasp[j] = data[r].Rasp;
                    j++;
                }
            }
            
            textBox1.Text = q[1];
            radioButton1.Text = var1[1];
            radioButton2.Text = var2[1];
            radioButton3.Text = var3[1];
        }

        private void cautare()
        {
            while (ct[nr_crt] == 1 && nr_crt <= intrb)//cauta intrebarile neraspunse
                nr_crt++;
        }
        private void modif(int x)
        {
            textBox1.Text = q[x];
            radioButton1.Text = var1[x];
            radioButton2.Text = var2[x];
            radioButton3.Text = var3[x];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nr_crt++;
            cautare();
            if(nr_crt>intrb)
            {
                nr_crt = 1;
                cautare();
            }
            label5.Text = Convert.ToString(nr_crt);
            modif(nr_crt);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                b = 1;
            else
                if (radioButton2.Checked == true)
                b = 2;
            else
                if (radioButton3.Checked == true)
                b = 3;
            else//eroare
            {
                b = 0;
                Form5 f = new Form5();
                f.ShowDialog();
                this.Show();
            }
            if(b!=0)
            {
                ramase--;
                l_gray.Text = Convert.ToString(ramase);
                //verif daca rezulatatul e corect
                if (rasp[nr_crt] == b)
                {
                    corecte++;
                    l_green.Text = Convert.ToString(corecte);
                    progressBar1.Value += 6;
                }
                else
                {
                    gresite++;
                    l_red.Text = Convert.ToString(gresite);
                }
                ct[nr_crt] = 1;
                //finalul testului
                if (ramase == 0)
                {
                    C = corecte;
                    Form4 f = new Form4();
                    this.Hide();
                    this.Close();
                    f.ShowDialog();
                    this.Show();
                    ramase = intrb;
                    corecte = 0;
                    gresite = 0;
                    l_green.Text = Convert.ToString(corecte);
                    l_red.Text = Convert.ToString(gresite);
                    l_gray.Text = Convert.ToString(ramase);
                }
                else//urm intrebare
                {
                    nr_crt++;
                    cautare();
                    if (nr_crt > intrb)
                    {
                        nr_crt = 1;
                        cautare();
                    }
                    modif(nr_crt);
                }
                label5.Text = Convert.ToString(nr_crt);
                if (ramase == 1)
                    button1.Visible = false;
                //refresh la optiuni
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            m--;
            if (m < 0)
            {
                m = 59;
                n--;
            }
            string t = Convert.ToString(m);
            if (m < 10)
                sec.Text = "0" + t;
            else
                sec.Text = t;
            t = Convert.ToString(n);
            if (n < 10)
                min.Text = "0" + t;
            else
                min.Text = t;
            if(n<5)
            {
                min.ForeColor = System.Drawing.Color.Red;
                sec.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
