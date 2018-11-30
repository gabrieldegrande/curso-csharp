using System;
using System.Globalization;

namespace Exercicio2.dominio
{
    class Artistas : IComparable
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public double cache { get; set; }

        public Artistas(int codigo, string nome, double cache)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cache = cache;
        }

        public override string ToString()
        {
            return $"{codigo}, {nome}, Cachê: R${cache.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            Artistas outro = (Artistas)obj;

            int resultado = nome.CompareTo(outro.nome);
            return resultado;
        }
    }
}
