namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Contrutores e Overloading (sobrecarga de construtor)
            //Criando primeiro objeto da classe Objeto.

            Objeto pessoa = new Objeto(); //aqui já se usa o metodo construtor com valores padrões.

            pessoa.nome = "Pedro Filipe";
            pessoa.sobrenome = "Tavares Baptista";
            pessoa.anoNascimento = 1996;
            pessoa.Idade();


            Console.WriteLine(pessoa.nome);
            Console.WriteLine(pessoa.sobrenome);
            Console.WriteLine(pessoa.anoNascimento);
            Console.WriteLine(pessoa.idade);

            Objeto pessoa2 = new Objeto("Arthur", "Gringo Viado", 1995, 28); //usando a segunda assinatura de construtor.


            Console.WriteLine("\n"+pessoa2.nome);
            Console.WriteLine(pessoa2.sobrenome);
            Console.WriteLine(pessoa2.anoNascimento);
            Console.WriteLine(pessoa2.idade);

            Objeto pessoa3 = new Objeto("Vinicius", "Mestre", 27);

            Console.WriteLine("\n" + pessoa3.nome);
            Console.WriteLine(pessoa3.sobrenome);
            Console.WriteLine(pessoa3.idade);
            #endregion



            Console.ReadLine();

        }
    }
}