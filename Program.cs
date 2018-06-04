using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro dogao = new Cachorro();
            // set tem como objetivo guardar determinada informação
            dogao.SetNome("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            dogao.SetAltura(1);
            dogao.SetPeso(1.1);
            dogao.SetRaca("Lulu da Pomerania");

            Console.WriteLine(dogao.GetNome());
            Console.WriteLine(dogao.GeteAltura());
            Console.WriteLine(dogao.GetPeso());
            Console.WriteLine(dogao.GetRaca());
        }
    }
}
