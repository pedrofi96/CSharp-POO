using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Conta c1 = new Conta();
            c1.Dinheiro = 1000;
            Console.WriteLine(c1.Dinheiro);
        }
    }
}
