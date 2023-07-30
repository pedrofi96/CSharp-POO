using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Pessoa : Interface
    {
        public string Name { get ; set ; }

        public void algumaCoisa()
        {
            Console.WriteLine("Alguma coisa, está acontecendo");
        }

        public void algumaCoisa(string name)
        {
            string msg;
            msg = name;

            Console.WriteLine("Olá " + msg);
        }

        public void outraCoisa()
        {
            Console.WriteLine("\nOutra coisa!");
        }
    }
}
