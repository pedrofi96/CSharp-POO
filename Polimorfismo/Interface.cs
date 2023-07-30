using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    interface Interface //Interface é uma classe que vai conter metodos e atributos mas não ira implementa-los e não pode ter um objeto dela mesma criado.
    {
        string Name { get; set; }


        void algumaCoisa();
        void algumaCoisa(string name);
        void outraCoisa();
    }
}
