using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmtechCalculator;

namespace AmtechCalculator.Calcule
{
    class Calcul
    {
        protected double lungime, kgtotal, pretkg, pretfinal,latime;
        string filePath = "D:\\AmtechCalculator\\DatabaseInfo.csv";
        public Calcul() { }
        public Calcul(double lungime, double kgtotal, double pretkg, double pretfinal, double latime)
        {
            this.lungime = lungime;
            this.pretkg = pretkg;
            this.pretfinal = pretfinal;
            this.latime = latime;
            this.kgtotal = kgtotal;
        }
        
        private void extrageDate()
        {

        }

        public void calculPlaca(double lungime, double kgtotal, double pretkg, double latime)
        {
            pretfinal = kgtotal * lungime * Math.Pow(10,-3) + latime * Math.Pow(10,-3) * pretkg;
        }

        public void calculBara(double lungime, double kgtotal, double pretkg)
        {
            pretfinal = lungime * kgtotal * pretkg;
        }
    }
}
