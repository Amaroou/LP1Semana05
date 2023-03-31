using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos dados quer lançar?");
            int numerodados = Int32.Parse(Console.ReadLine());

            Console.WriteLine(numerodados);
            int dicenum;
            Random random = new Random();
            int soma=0;
            for (int i = 0; i < numerodados; i++)
            {
                dicenum = random.Next(1, 7);
                Console.WriteLine("calhou: " + dicenum);

            }




        }
    }
}
