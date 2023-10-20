using System;

namespace Aula
{
    class Carro
    {
        private int velMax;

        public int vm
        {
            get { return this.velMax; }
            set
            {
                if (value < 0)
                {
                    velMax = 0;
                }
                else if (value > 300)
                {
                    velMax = 300;
                }
                else
                {
                    velMax = value;
                }
            }
        }
        public Carro()
        {
            vm = 140;
        }
    }
    class Aula41
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            Console.WriteLine(c1.vm);
        }
    }

}