using System;

namespace Aula
{
    class Jogador
    {
        public int energia;
        public bool vivo;
        public string nome;
        public Jogador(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
        ~Jogador()
        {
            Console.WriteLine("O jogador morreu");
        }
    }

    class Aula29
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador("Erick");
            int dano = 0;
            do
            {
                Console.WriteLine("Nome do jogador 1: {0}", j1.nome);
                Console.WriteLine("O jogador 1 encontrou um inimigo quanto de vida ele perdeu?");
                dano = Convert.ToInt32(Console.ReadLine());
                j1.energia = j1.energia - dano;
                Console.WriteLine("jogador tomou dano de: {0} , a vida dele e : {1}", dano, j1.energia);
                if (j1.energia < 1)
                {
                    j1.vivo = false;
                    Console.WriteLine($"Jogador {j1.nome} Morreu");
                }
            }
            while (j1.vivo == true);
        }
    }
}