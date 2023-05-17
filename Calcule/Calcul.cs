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
        protected float lungime, kgtotal, pretkg, pretfinal,latime;
        
        public Calcul() { }
        public Calcul(float lungime, float kgtotal, float pretkg, float pretfinal, float latime)
        {
            this.lungime = lungime;
            this.pretkg = pretkg;
            this.pretfinal = pretfinal;
            this.latime = latime;
            this.kgtotal = kgtotal;
        }

        

        public float calculPlaca(float lungime, float latime, float kgtotal, float pretkg)
        {
            pretfinal = (float)(kgtotal * lungime * Math.Pow(10,-3) + latime * Math.Pow(10,-3) * pretkg);
            return pretfinal;
        }

        public float calculBara(float lungime, float kgtotal, float pretkg)
        {
            pretfinal =(float) lungime* (float)Math.Pow(10,-3) * kgtotal * pretkg;
            return pretfinal;
        }
    }
}
