using System;

namespace LuckyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = true;
            while (resultado)
            {
                int numeroAleatorio = new Random().Next(100);
                Console.WriteLine("What's your name");
                var name = Console.ReadLine();
                Console.WriteLine("Your name is: " + name);
                Console.WriteLine("Today is your lucky day!!");
                Console.WriteLine("The Number is ");
                Console.WriteLine(numeroAleatorio);

                int number = 0;
                while (number < 99) // condition
                {
                    //Console.WriteLine("number = {0}", number);

                    number++;

                    if (number < 99)
                    {
                        Console.WriteLine("You're gonna win the lottery");
                    }
                    else if (number > 20)
                    {
                        Console.WriteLine("Not lucky");
                    }
                    else
                    {
                        Console.WriteLine("Try it again next time");
                    }

                    Console.ReadLine();


                }
            }
        }
    }
}
