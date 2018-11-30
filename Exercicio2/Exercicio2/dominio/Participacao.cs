using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.dominio
{
    class Participacao
    {
        public double desconto { get; set; }
        public Artistas artista { get; set; }

        public Participacao(Artistas artista, double desconto)
        {
            this.artista = artista;
            this.desconto = desconto;
        }

        public double custo()
        {
            return artista.cache - desconto;
        }

        public override string ToString()
        {
            return  $"{artista.nome}, Cache R${artista.cache.ToString("F2", CultureInfo.InvariantCulture)}, " +
                    $"Desconto: {desconto.ToString("F2", CultureInfo.InvariantCulture)}, " +
                    $"Custo: {custo().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
