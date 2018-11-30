using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula10
{
    class Retangulo
    {
        public Cor cor { get; set; }
        public double largura { get; set; }
        public double altura { get; set; }

        public Retangulo(double largura, double altura, Cor cor)
        {
            this.altura = altura;
            this.largura = largura;
            this.cor = cor;
        }
    }
}
