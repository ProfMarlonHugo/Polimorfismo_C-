using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Polimorfismo
{
    public abstract class Forma
    {
        protected string cor;
        protected bool preenchida;

        /*Construtor - Polimorfismo de sobrecarga*/
        public Forma()
        {
            this.Cor = "Vermelho";
            this.Preenchida = true;
        }

        public Forma(string c, bool b)
        {
            this.Cor = c;
            this.Preenchida = b;
        }

        /*get set*/
        public string Cor
        {
            get
            {
                return cor;
            }
            set
            {
                cor = value;
            }
        }

        public bool Preenchida
        {
            get
            {
                return preenchida;
            }
            set
            {
                preenchida = value;
            }
        }

        /*Métodos abstratos, não possui implemantação */
        public abstract double getArea();
        public abstract double getPerimetro();

        /* Retorna uma string*/
        public virtual string toString()
        {
            return "Forma ( cor= " + Cor + ", Preenchida=" + Preenchida + ")"; 
        }
    }
}
