using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_atestat
{
    class Grila
    {
        private string intrebare;
        private string opt1;
        private string opt2;
        private string opt3;
        private int rasp_corect;
        
        public Grila(string intrebare,string opt1,string opt2,string opt3,int rasp_corect)
        {
            this.intrebare = intrebare;
            this.opt1 = opt1;
            this.opt2 = opt2;
            this.opt3 = opt3;
            this.rasp_corect = rasp_corect;
        }
        public string Intrebare
        {
            get
            {
                return this.intrebare;
            }
        }
        public string Opt1
        {
            get
            {
                return this.opt1;
            }
        }
        public string Opt2
        {
            get
            {
                return this.opt2;
            }
        }
        public string Opt3
        {
            get
            {
                return this.opt3;
            }
        }
        public int Rasp
        {
            get
            {
                return this.rasp_corect;
            }
        }
    }
}
