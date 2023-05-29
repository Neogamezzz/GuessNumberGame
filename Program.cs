using System;

namespace GuessNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rnd = new Random().Next(0, 101);
            int attempt = 0;
            Console.WriteLine("I have a number between 0 and 100. Try to guess it.");

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int userNumber))
                {
                    Console.WriteLine("Invalid value. Try again.");
                    continue;
                }

                attempt++;
                if (userNumber < rnd)
                {
                    Console.WriteLine("I’m guessing a bigger number. Try again.");
                }
                else if (userNumber > rnd)
                {
                    Console.WriteLine("I’m guessing a smaller number. Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed my number in {attempt} attempts.");
                    return;
                }
            }
        }
    }
}
