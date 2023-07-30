using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstatica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classe estatica matematica.
            Matematica.taxa = 100;
            int valor = Matematica.adicionar(500);
            int valor2 = Matematica.diminuir(500);

            Console.WriteLine(valor);
            Console.WriteLine(valor2);
            Console.WriteLine("Sua taxa é de: " + Matematica.taxa);
            
            #endregion


            Pessoa.maioridade = 21;
            Pessoa p1 = new Pessoa();
            p1.nome = "Pedro Filipe";
            p1.idade = Pessoa.CalcularIdade(1996);

            Console.WriteLine("Nome: "+ p1.nome);
            Console.WriteLine("Idade: "+p1.idade);
            Console.WriteLine("Maioridade: "+ Pessoa.maioridade);
            Console.ReadKey();

        }
    }
}
