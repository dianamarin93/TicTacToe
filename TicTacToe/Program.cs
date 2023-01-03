using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] positions = new char[9];

            char playerToken = 'X';
            char botToken = '0';

            List<int> availablePositions = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random rnd = new Random();

            while (true)
            {
                Console.Write("Enter a position where you want to play this round: ");
                int inputPosition = Convert.ToInt32(Console.ReadLine());


                if (inputPosition > 0 && inputPosition < 10 && availablePositions.Contains(inputPosition))
                {
                    positions[inputPosition - 1] = 'X';
                    availablePositions.Remove(inputPosition);
                    if (availablePositions.Count > 0)
                    {
                        int botPosition = availablePositions[rnd.Next(0, availablePositions.Count)];
                        positions[botPosition - 1] = botToken;
                        availablePositions.Remove(botPosition);
                    }
                    else
                    {
                        Console.WriteLine("Draw!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid position, must be between 1 and 9");
                }

                Console.WriteLine($"\n {positions[0]} | {positions[1]} | {positions[2]} ");
                Console.WriteLine("---+---+---");
                Console.WriteLine($" {positions[3]} | {positions[4]} | {positions[5]} ");
                Console.WriteLine("---+---+---");
                Console.WriteLine($" {positions[6]} | {positions[7]} | {positions[8]} \n");

                if (positions[0] == 'X' && positions[1] == 'X' && positions[2] == 'X'
                    || positions[3] == 'X' && positions[4] == 'X' && positions[5] == 'X'
                    || positions[6] == 'X' && positions[7] == 'X' && positions[8] == 'X'
                    || positions[0] == 'X' && positions[3] == 'X' && positions[6] == 'X'
                    || positions[1] == 'X' && positions[4] == 'X' && positions[7] == 'X'
                    || positions[2] == 'X' && positions[5] == 'X' && positions[8] == 'X'
                    || positions[0] == 'X' && positions[4] == 'X' && positions[9] == 'X'
                    || positions[2] == 'X' && positions[4] == 'X' && positions[6] == 'X')
                {
                    Console.WriteLine("You won!");
                    break;
                }



                if (positions[0] == '0' && positions[1] == '0' && positions[2] == '0'
                         || positions[3] == '0' && positions[4] == '0' && positions[5] == '0'
                         || positions[6] == '0' && positions[7] == '0' && positions[8] == '0'
                         || positions[0] == '0' && positions[3] == '0' && positions[6] == '0'
                         || positions[1] == '0' && positions[4] == '0' && positions[7] == '0'
                         || positions[2] == '0' && positions[5] == '0' && positions[8] == '0'
                         || positions[0] == '0' && positions[4] == '0' && positions[9] == '0'
                         || positions[2] == '0' && positions[4] == '0' && positions[6] == '0')
                {
                    Console.WriteLine("Computer won!");
                    break;
                }

                if (availablePositions.Count == 0)
                {
                    Console.WriteLine("Draw");
                    break;
                }
            }



            Console.ReadKey();
        }
    }
}
