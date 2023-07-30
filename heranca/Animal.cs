using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Animal : Mamiferos
    {
        public bool vivo { get; set; }
        public string name { get; set; }
        public int numeroPatas { get; set; }
        public string   cor { get; set; }

        public Animal(string name, int numeroPatas, string cor, bool vivo)
        {
            this.name = name;
            this.numeroPatas = numeroPatas;
            this.cor = cor;
            this.vivo = vivo;
        }
        public Animal()
        {

        }
        public void comer()
        {
            Console.WriteLine("comendo");
        }

        public void beber()
        {
            Console.WriteLine("bebendo");
        }

        public void morrer()
        {
            Console.WriteLine( this.name + "Morreu");
            this.vivo = false;
        }

        public override string ToString()
        {
            string msg;
            if (this.vivo)
            {
                msg = "Vivo";
            }
            else
            {
                msg = "Morto";
            }
            return "\nO nome do Animal é: "+this.name+"\nEstá: "+msg+"\nTem "+this.numeroPatas+" Patas"+"\nE é da cor: "+this.cor;
        }
    }
}
