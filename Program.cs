using System;

namespace Exercicio_individual_Tema_Encapsulamento_e_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("PS5", 2000.00, 5); //instancia um objeto passando paramentros ja na sua instanciação

            p.Nome = "3DS"; // muda o nome do produto para 3DS

            Console.WriteLine(p.Nome); //mostra no console o nome do objeto
            Console.WriteLine(p.Preco); //mostra no console o preco do objeto
            Console.WriteLine(p.Quantidade); //mostra no console a quantidade do objeto

            Console.ReadKey();
        }
    }
}
