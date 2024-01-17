using System;

class Program
{
    static void Main(string[] args)
    {
        // get random number
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 11);

        bool correctGuess = false;
        while (!correctGuess)
        {
            // ask for guess
            Console.Write("Please enter a guess a number: ");
            int guess = int.Parse(Console.ReadLine());

            // if guess is too high, say so
            if (guess > randomNumber)
            {
                Console.WriteLine("Too high!");
            }

            // if guess is too low, say so

            if (guess < randomNumber)
            {
                Console.WriteLine("Too low!");
            }

            // if guess is correct, say so

            if (guess == randomNumber)
            {
                Console.WriteLine("You guessed it!");
                correctGuess = true;
            }
        }
    }
}