using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Name = "Flavia Deusa";
            p1.algumaCoisa();
            p1.outraCoisa();
            p1.algumaCoisa(p1.Name);

            // Interface I1 = new Interface();  
            //Interface não pode ser instanciada por ser uma interface uma classe coma tributos e metodos a serem utilizados por outra classe.


        }
    }
}
