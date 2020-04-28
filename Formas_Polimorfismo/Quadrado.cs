using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Polimorfismo
{
    class Quadrado : Retangulo
    {
         /*Contrutores - Polimorfismo de Sobrecarga*/
        public Quadrado()
        {
            this.Altura = this.Largura;
        }
        
        public Quadrado(double lado)
        {
            this.Lado = lado;
        }   

        public Quadrado(double lado, string cor, bool preenchida)
        {
            this.Lado = lado;
            this.Cor = cor;
            this.Preenchida = preenchida;
        }

        /*Get set*/
        public double Lado
        {
            get
            {
                return this.Altura;
            }
            set
            {
                this.Altura = value;
                this.Largura = value;
            }
        }

        /*metodo de sobreposicao*/
        public override string toString()
        {
            return "Quadrado (" + base.toString() + 
                ", altura = " + this.Altura + ", largura =" + this.Largura + " )";
        }
    }
}
