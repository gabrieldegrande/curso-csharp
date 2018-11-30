using System;

namespace aula08
{
   //interface figura                     ~ Interface possui somente métodos abstratos
    abstract class Figura           
    {
        public string cor { get; set; } //~ Não seria possível implementar cor se fosse uma interface

        public Figura(string cor)
        {
            this.cor = cor;
        }
      //Não seria necessário 'public abstract' se fosse interface, pois todos os métodos da interface são abstratos
        public abstract double area();
        public abstract double perimetro();
    }
}
