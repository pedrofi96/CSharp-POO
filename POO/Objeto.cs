using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Objeto
    {

        //encapsulamente dos Atributos.
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public int anoNascimento { get; set; }
        public int idade { get; private set; }

        public void Idade()
        {
            this.idade = DateTime.Now.Year - this.anoNascimento;
        }

        public Objeto() //construtor
        {
            nome = "Desconhecido";
            sobrenome = "Desconhecido";
            anoNascimento = 0;
            idade = 0;
        }

        public Objeto(string nome, string sobrenome, int anoNascimento, int idade) //sobrecarga de construtor (overloading)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNascimento=anoNascimento;
            this.idade = idade;

        }

        public Objeto(string nome, string sobrenome, int idade)
        {
            this.nome = nome;
            this.sobrenome= sobrenome;
            this.idade= idade;
        }


    }
}
