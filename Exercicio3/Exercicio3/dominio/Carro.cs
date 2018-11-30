using System;
using System.Collections.Generic;
using System.Globalization;


namespace Exercicio3.dominio
{
    class Carro : IComparable
    {
        public int codigo { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public double precoBasico { get; set; }
        public Marca marca { get; set; }
        public List<Acessorio> acessorios { get; set; }

        public Carro(int codigo, string modelo, int ano, double precoBasico, Marca marca)
        {
            this.codigo = codigo;
            this.modelo = modelo;
            this.ano = ano;
            this.precoBasico = precoBasico;
            this.marca = marca;
            acessorios = new List<Acessorio>();
        }

        public double precoTotal()
        {
            double soma = 0.0;

            for (int i = 0; i < acessorios.Count; i++)
            {
                soma = soma + acessorios[i].preco;
            }
            return precoBasico + soma;
        }

        public string imprimir()
        {
            return $"{codigo}, {modelo}, {ano} {precoTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public override string ToString()
        {
            string s = $"{codigo}, {modelo}, Ano: {ano}, Preço básico: {precoBasico.ToString("F2", CultureInfo.InvariantCulture)}, " +
                       $"Preço total: {precoTotal().ToString("F2", CultureInfo.InvariantCulture)}";
            if(acessorios.Count > 0)
            {
            s = s + "\nAcessórios: ";
            for (int i = 0; i < acessorios.Count; i++)
            {
                    s = s + "\n" + acessorios[i];
            }
            }
            return s;
        }

        public int CompareTo(object obj)
        {
            Carro outro = (Carro)obj;
            int resultado = modelo.CompareTo(outro.modelo);

            if(resultado != 0)
            {
                return resultado;
            }
            else
            {
                return -precoTotal().CompareTo(outro.precoTotal());
            }
        }
    }
}
