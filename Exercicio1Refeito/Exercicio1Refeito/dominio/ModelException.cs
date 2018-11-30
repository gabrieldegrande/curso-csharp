using System;

namespace Exercicio1Refeito.dominio
{
    class ModelException : Exception
    {
        public ModelException(string msg): base(msg)
        {
        }
    }
}
