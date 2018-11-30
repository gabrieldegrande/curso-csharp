using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.dominio
{
    class Filme
    {
        public int codigo { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }
        public List<Participacao> parts { get; set; }

        public Filme(int codigo, string titulo, int ano)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano;
            parts = new List<Participacao>();
        }

        public double custoTotal()
        {
            double soma = 0.0;
            for(int i = 0; i < parts.Count; i++)
            {
                soma = soma + parts[i].custo();
            }
            return soma;
        }

        public override string ToString()
        {
            string s    = $"Filme {codigo}, Título: {titulo}, Ano: {ano}\n"
            +"Participações: \n";
            for(int i = 0; i< parts.Count; i++)
            {
                s = s + parts[i] + "\n";
            }
            s = s + $"Custo total do filme: R${custoTotal().ToString("F2", CultureInfo.InvariantCulture)}";
            return s;
        }
    }
}
