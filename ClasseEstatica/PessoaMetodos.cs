using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstatica
{
    internal partial class Pessoa
    {
        //classe partial é como se fosse a continuação de uma classe já existente serve para deixar mais organizado mas funciona como se fosse apenas uma classe normal.
        public void Apresentar()
        {
            Console.WriteLine("Olá eu sou " + nome);
        }

        public static int CalcularIdade(int anoNascimento) //metodo static é chamado direto no objeto ex: Pessoa.CalcularIdade();
        {
            return DateTime.Now.Year - anoNascimento;
        }


    }
}
