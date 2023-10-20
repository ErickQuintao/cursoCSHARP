using System;

namespace Aula
{
    class Jogador
    {
        public int energia;
        public bool vivo;
        public string nome;
        public Jogador()
        {
            energia = 100;
            vivo = true;
            nome = "Jogador";
        }
        public Jogador(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
        public Jogador(string n, int e)
        {
            energia = e;
            vivo = true;
            nome = n;
        }
        public Jogador(string n, int e, bool v)
        {
            energia = e;
            vivo = v;
            nome = n;
        }
        public void info()
        {
            Console.WriteLine("Nome jogador...:{0}", nome);
            Console.WriteLine("Energia jogador...:{0}", energia);
            Console.WriteLine("Estado jogador...:{0}", vivo);
            Console.WriteLine("--------------");
        }
        ~Jogador()
        {
            Console.WriteLine("O jogador morreu");
        }
    }

    class Aula30
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador("Erick");
            Jogador j2 = new Jogador();
            Jogador j3 = new Jogador("théo", 200);
            j1.info();
            j2.info();
            j3.info();
        }
    }
}