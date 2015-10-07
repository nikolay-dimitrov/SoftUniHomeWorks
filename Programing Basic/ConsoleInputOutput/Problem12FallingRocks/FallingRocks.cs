using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace FallingRocks
{
    
    class GameObject
    {
        public int col;
        public int row;
        public ConsoleColor color;
    }
    class Dwarf : GameObject
    {
        public readonly string shape = "(0)";
    }
    class Rock : GameObject
    {
        public char shape;
    }
    enum HitPosition
    {
        None = 0,
        HitLeft = 1,
        HitCenter = 2,
        HitRight = 3
    }
    enum RockShape
    {
        Rock = '@',
        Heart = 3,
        Money = '$'
    }

    class Program
    {
        static readonly string[] hitshapes = new string[] { "", "X0)", "(X)", "(0X" };
        static void PrintOnPosition(int col, int row, char chartoprint,
            ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = color;
            Console.Write(chartoprint);
        }

        static void PrintOnPosition(int col, int row, string stringtoprint,
            ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = color;
            Console.Write(stringtoprint);
        }
        static void Main()
        {
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight = 18;
            Console.WindowWidth = 20;
            Console.BufferWidth = 20;

            Random randomGenerator = new Random();
            double sleeptime = 200;
            double score = 0;
            int lives = 5;

            Dwarf newDwarf = new Dwarf();
            newDwarf.col = 9;
            newDwarf.row = Console.WindowHeight - 1;
            newDwarf.color = ConsoleColor.Gray;

            List<Rock> Rocks = new List<Rock>();

            PrintOnPosition(0, 5, " The aim of the game is to avoid all the rocks. Good luck!", ConsoleColor.Yellow);
            PrintOnPosition(0, 9, "Pick", ConsoleColor.Yellow);
            PrintOnPosition(5, 9, (char)3, ConsoleColor.Red);
            PrintOnPosition(7, 9, "for lives", ConsoleColor.Yellow);
            PrintOnPosition(0, 10, "Pick", ConsoleColor.Yellow);
            PrintOnPosition(5, 10, '$', ConsoleColor.Green);
            PrintOnPosition(7, 10, "for money", ConsoleColor.Yellow);
            PrintOnPosition(5, 13, "Good luck!", ConsoleColor.Red);
            PrintOnPosition(17, 0, ' ', ConsoleColor.Black);
            Console.ReadLine();
            Console.Clear();

            for (int i = 0; i <= Console.WindowWidth - 1; i++)
            {
                PrintOnPosition(i, 4, '_', ConsoleColor.White);
            }

            while (true)
            {
                HitPosition newHitPosition = HitPosition.None;

                int chance = randomGenerator.Next(0, 100);

                {
                    Rock newRock = new Rock();
                    newRock.col = randomGenerator.Next(0, 19);
                    newRock.row = 5;


                    if (chance < 1)
                    {
                        newRock.shape = (char)RockShape.Heart;
                        newRock.color = ConsoleColor.Red;
                    }
                    else if (chance < 10)
                    {
                        newRock.shape = (char)RockShape.Money;
                        newRock.color = ConsoleColor.Green;
                    }
                    else if (chance < 100)
                    {
                        newRock.shape = (char)RockShape.Rock;
                        newRock.color = ConsoleColor.Cyan;
                    }
                    Rocks.Add(newRock);
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    if (userInput.Key == ConsoleKey.LeftArrow && newDwarf.col > 0)
                    {
                        PrintOnPosition(newDwarf.col--, newDwarf.row, "   ", newDwarf.color);
                    }
                    if (userInput.Key == ConsoleKey.RightArrow && newDwarf.col < Console.WindowWidth - 2)
                    {
                        PrintOnPosition(newDwarf.col++, newDwarf.row, "   ", newDwarf.color);
                    }
                }
                PrintOnPosition(newDwarf.col, newDwarf.row, newDwarf.shape, newDwarf.color);

                List<Rock> newList = new List<Rock>();
                for (int i = 0; i < Rocks.Count; i++)
                {
                    Rock oldRock = Rocks[i];
                    Rock newRock = new Rock();
                    newRock.col = oldRock.col;
                    newRock.row = oldRock.row + 1;
                    newRock.shape = oldRock.shape;
                    newRock.color = oldRock.color;

                    if ((newRock.col == newDwarf.col || newRock.col == newDwarf.col + 1 || newRock.col == newDwarf.col + 2) && newRock.row == newDwarf.row)
                    {
                        switch (newRock.shape)
                        {
                            case '@':
                                newHitPosition = (HitPosition)Enum.Parse(typeof(HitPosition), ((newRock.col - newDwarf.col) + 1).ToString());
                                break;
                            case '$':
                                score += 500;
                                break;
                            case (char)3:
                                lives += 1;
                                break;
                        }
                    }
                    if (newRock.row < Console.WindowHeight)
                    {
                        newList.Add(newRock);
                    }
                }

                if (newHitPosition != HitPosition.None)
                {
                    PrintOnPosition(newDwarf.col, newDwarf.row, hitshapes[(int)newHitPosition], ConsoleColor.Red);
                    if (lives < 2)
                    {
                        PrintOnPosition(0, 0, "GAME OVER!", ConsoleColor.Red);                     
                        PrintOnPosition(17, 0, ' ', ConsoleColor.Black);
                        Console.ReadLine();
                        PrintOnPosition(0, 0, @"           ", ConsoleColor.Red);
                        return;
                    }

                    PrintOnPosition(0, 0, "Press enter", ConsoleColor.Red);
                    PrintOnPosition(17, 0, ' ', ConsoleColor.Black);
                    Console.ReadLine();
                    PrintOnPosition(0, 0, @"           ", ConsoleColor.Red);
                    foreach (Rock rock in Rocks)
                    {
                        PrintOnPosition(rock.col, rock.row, ' ', ConsoleColor.Black);
                    }
                    Rocks.Clear();
                    newList.Clear();
                    lives--;
                    sleeptime += 20;
                }
 
                foreach (Rock rock in Rocks)
                {
                    PrintOnPosition(rock.col, rock.row, ' ', ConsoleColor.Black);
                }
                Rocks = newList;

                foreach (Rock rock in Rocks)
                {
                    PrintOnPosition(rock.col, rock.row, rock.shape, rock.color);
                }

                PrintOnPosition(7, 2, "Score: " + (int)score, ConsoleColor.Cyan);
                PrintOnPosition(7, 3, "Lives: " + lives, ConsoleColor.Yellow);

                score += 14.66;
                sleeptime -= 0.5;
                if (sleeptime < 100)
                {
                    sleeptime = 100;
                }

                if (sleeptime > 200)
                {
                    sleeptime = 200;
                }

                Thread.Sleep((int)sleeptime);
            }
        }
    }
}