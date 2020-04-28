using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Polimorfismo
{
    class Circulo : Forma
    {
        protected double raio;

        /*Construtores - Polimorfismo de sobrecarga*/
        public Circulo()
        {
            this.Raio = 1.0;
        }

        public Circulo(double r) 
        {
            this.Raio = r;
        }

        public Circulo(double r, string cor, bool preenchida)
        {
            this.Raio = r;
            this.Cor = cor;
            this.Preenchida = preenchida;
        }

        /* GET SET*/
        public double Raio
        {
            get
            {
                return raio;
            }
            set
            {
                raio = value;
            }
        }

        /*Métodos - Plimorfismo de Sobreposição*/
        public override double getArea()
        {
            // A = PI * raio ^ 2
            return Math.PI * Math.Pow(this.Raio,2) ;
        }

        public override double getPerimetro()
        {
            // P = 2 * PI * raio
            return 2 * Math.PI * this.Raio;
        }

        public override string toString()
        {
            return "Circulo (" + base.toString() + ", raio = " + this.Raio + ")";
        }
    }
}
