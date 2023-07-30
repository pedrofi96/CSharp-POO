using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal sealed class Cachorro : Animal //classe Cachorro herda caracteristicas da classe Animal
    {
        //sealed define que essa classe (cachorro) não pode ser herdada.
        public string latido { get; set; }


        public Cachorro() : base() //polimorfismo de construtor esta herdando construtor de animal e dando um outro metodo para o mesmo.
        {
            this.name = "Cachorro";
        }

        public void correndo()
        {
            Console.WriteLine("O au-au está correndo ");
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
            return "\nO nome do Animal é: " + this.name + "\nEstá: " + msg + "\nTem " + this.numeroPatas + " Patas" + "\nE é da cor: " + this.cor+"\nTem latido: "+this.latido;
        }

    }
}
