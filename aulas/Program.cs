// See https://aka.ms/new-console-template for more information
using System;

namespace aulas
{
    class Program
    {

        static void Main(string[] args)
        {
            byte nx = 10;// 0 e 255
            int num = -10;
            char letrar = 'g';
            float valor = 5.3f;
            string nome = "Bruno";

            var aux = 10;
            int n1 = 10;
            int n2 = 20;
            int n3 = 30;
            Console.WriteLine(n1 + " " + n2 + " " + n3 + " ");

            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.1;
            string produto = "Pastel";
            valorVenda = valorCompra + (valorCompra * lucro);

            Console.WriteLine("Produto.......:{0,15}", valorCompra);
            Console.WriteLine("Produto.......:{0,15:c}", valorCompra);
            Console.WriteLine("Produto.......:{0,15:p}", lucro);
            Console.WriteLine("Produto.......:{0,15:c}", valorVenda);
        }
    }
}
