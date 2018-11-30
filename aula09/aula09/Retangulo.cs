using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09
{
    class Retangulo
    {
        public double altura { get; set; }
        public double largura { get; set; }

        public Retangulo(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;
        }

        public double area()
        {
            return largura * altura;
        }

    }
}
