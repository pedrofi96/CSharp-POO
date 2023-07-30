using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal a1 = new Animal();
            a1.vivo = true;
            a1.cor = "Marrom";
            a1.name = "Alien";
            a1.numeroPatas = 2;
            
        
            Cachorro c1 = new Cachorro();
            c1.cor = a1.cor;
            c1.name = "Viralata Caramelo";
            c1.vivo = true;
            c1.numeroPatas = 4;
            c1.latido = "Agudo";
            
            Console.WriteLine(a1.ToString());
            Console.WriteLine(c1.ToString());
            a1.morrer();
            c1.correndo();

            Console.ReadKey();
        }

    }
}
