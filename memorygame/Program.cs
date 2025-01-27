using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Patterngame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = new List<int>();
            Random random = new Random();

            for (int round = 1; round <= 9999; round++) 
            {
                int newNumber = random.Next(1, 10);
                sequence.Add(newNumber);
                Console.Clear();
                Console.WriteLine($"Round {round}");
                Console.WriteLine("Remeber this");
                foreach (var number in sequence)
                {
                    Console.WriteLine(number + " ");
                }
                Thread.Sleep(2000); //2 seconds (change if you want it easier/harder)
                Console.Clear();
                Console.WriteLine("Enter the Sequence that was shown"); //input from player
                List<int> playerInput = new List<int>();
                for (int i = 0; i < sequence.Count; i++)
                {
                    int input = 0;
                    bool validInput = false;
                    while (!validInput)
                    {
                        Console.WriteLine($"Enter number {i + 1} of the sequence");
                        string userInput = Console.ReadLine();
                        if (int.TryParse(userInput, out input))
                        {
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input enter a valid number");
                        }
                    }
                    playerInput.Add(input);
                }
                bool isCorrect = true;
                if (playerInput.Count == sequence.Count)
                {
                    for (int num = 0; num < sequence.Count; num++)
                    {
                        if (sequence[num] != playerInput[num])
                        {
                            isCorrect = false;   //game over 
                            Console.WriteLine("Incorrect! Game Over");
                            Environment.Exit(0);
                            break;
                        }
                    }
                }

                else
                {
                    isCorrect = false;
                }
                if (isCorrect)
                {
                    Console.WriteLine("Correct you remebered the sequence!");
                }
                Console.WriteLine("Press any key to continue to the next round"); //round progression
                Console.ReadKey();
            }
        }
    }

}


