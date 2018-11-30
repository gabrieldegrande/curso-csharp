using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula08
{
    class Retangulo : Figura
    {
        public double largura { get; set; }
        public double altura { get; set; }

        public Retangulo(double largura, double altura, string cor) : base(cor)
        {
            this.largura = largura;
            this.altura = altura;
        }

        // se Figura fosse uma interface, não é necessário 'override'
        public override double perimetro()
        {
            return 2 * (largura + altura) ;
        }

        // se Figura fosse uma interface, não é necessário 'override'
        public override double area()
        {
            return largura * altura;
        }
    }
}
