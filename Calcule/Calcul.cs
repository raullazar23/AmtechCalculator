using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmtechCalculator;

namespace AmtechCalculator.Calcule
{
    class Calcul : DataExtractor
    {
        protected double lungime, kgtotal, pretkg, pretfinal,latime;
        
        public Calcul() { }
        public Calcul(double lungime, double kgtotal, double pretkg, double pretfinal, double latime)
        {
            this.lungime = lungime;
            this.pretkg = pretkg;
            this.pretfinal = pretfinal;
            this.latime = latime;
            this.kgtotal = kgtotal;
        }

        

        public void calculPlaca()
        {
            
            pretfinal = kgtotal * lungime * Math.Pow(10,-3) + latime * Math.Pow(10,-3) * pretkg;
        }

        public double calculBara(double lungime, double kgtotal, double pretkg)
        {
            pretfinal = lungime * kgtotal * pretkg;
            return pretfinal;
        }
    }
}
