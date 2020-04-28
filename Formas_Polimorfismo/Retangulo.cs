using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Polimorfismo
{
    class Retangulo : Forma
    {
        protected double altura;
        protected double largura;

        /*Construtor - Polimorfismo de Sobrecarga*/
        public Retangulo()
        {
            this.Altura = 1.0;
            this.Largura = 1.0;
        }

        public Retangulo(double altura, double largura)
        {
            this.Altura = altura;
            this.Largura = largura;
        }

        public Retangulo(double altura, double largura, string cor, bool preenchida)
        {
            this.Altura = altura;
            this.Largura = largura;
            this.Cor = cor;
            this.Preenchida = preenchida;
        }

        /* get set*/
        public double Altura
        {
            get
            {
                return altura;
            }
            set
            {
                altura = value;
            }
        }

        public double Largura
        {
            get
            {
                return largura;
            }
            set
            {
                largura = value;
            }
        }

        /*Atributors  = Polimorfismo de sobrecarga*/
        public override double getArea()
        {
            //A = largura * altura
            return this.Largura * this.Altura;
        }

        public override double getPerimetro()
        {
            //P = 2 * (largura + altura)
            return 2 * (this.Largura + this.Altura);
        }

        public override string toString()
        {
            return "Retangulo (" + base.toString() +
                ", altura =" + this.Altura + " largura="+ this.Largura+")";
        }
    }
}
