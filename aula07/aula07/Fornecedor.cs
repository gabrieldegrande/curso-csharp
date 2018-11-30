using System;

namespace curso
{
    class Fornecedor
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

        public Fornecedor(string nome, string email, string telefone)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone; 
        }

        public override string ToString()
        {
            return $"{nome}, {email}, {telefone}";
        }
    }
}
 