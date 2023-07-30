using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstatica
{
    internal static class Matematica
    {
        //Classe estatica não cria objetos e chamamos a classe direto no programa, funciona como se fosse uma function em javascript
        public static int taxa;

        public static int adicionar(int valor)
        {
            return valor+taxa;
        }
        public static int diminuir(int valor)
        {
            return valor - taxa;
        }
    }
}
