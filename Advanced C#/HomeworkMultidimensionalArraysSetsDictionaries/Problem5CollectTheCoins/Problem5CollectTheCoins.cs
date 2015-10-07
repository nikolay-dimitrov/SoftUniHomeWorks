using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5CollectTheCoins
{
    class Problem5CollectTheCoins
    {
        //static int x = 0;
        //static int y = 0;
        //static char[][] matrix;
        //static int walls = 0;
        //static int coins = 0;
        //static int xRight;
        //static int yRight;


        //static void DoMoves(char[] moves)
        //{
        //    for (int i = 0; i < moves.Length; i++)
        //    {
        //        if (moves[i] == 'V')
        //        {
        //            y++;
        //            CheckForCoins();
        //        }
        //        else if (moves[i] == '^')
        //        {
        //            y--;
        //            CheckForCoins();

        //        }
        //        else if (moves[i]=='>')
        //        {
        //            x++;
        //            CheckForCoins();
        //        }
        //        else if (moves[i] =='<')
        //        {
        //            x--;
        //            CheckForCoins();
        //        }
        //    }

        //}
        //static void CheckForCoins()
        //{
        //    char currentPosition;
        //    try
        //    {
        //        currentPosition = matrix[y][x];
        //        if (currentPosition == '$')
        //        {
        //            coins++;
        //        }
        //        xRight = x;
        //        yRight = y;

        //    }
        //    catch (IndexOutOfRangeException exc)
        //    {
                
        //        walls++;
        //        x = xRight;
        //        y = yRight;
        //    }

        //}
        //static void Main(string[] args)
        //{
        //    matrix = new char[4][];

        //    for (int a = 0; a < matrix.Length; a++)
        //    {
        //        char[] input = Console.ReadLine().ToCharArray();
        //        matrix[a] = input;
        //    }
        //    char[] moves = Console.ReadLine().ToCharArray();
        //    DoMoves(moves);

        //    Console.WriteLine("Coins collected {0}", coins);
        //    Console.WriteLine("Walls hit {0}", walls); 
 


        static void DoMoves(char[] moves)
        {
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'V')
                {
                    y++;
                    CheckForCoins();
                }
                else if (moves[i] == '^')
                {
                    y--;
                    CheckForCoins();

                }
                else if (moves[i]=='>')
                {
                    x++;
                    CheckForCoins();
                }
                else if (moves[i] =='<')
                {
                    x--;
                    CheckForCoins();
                }
            }

        }
        static void CheckForCoins()
        {
            char currentPosition;
            try
            {
                currentPosition = matrix[y][x];
                if (currentPosition == '$')
                {
                    coins++;
                }
                xRight = x;
                yRight = y;

            }
            catch (IndexOutOfRangeException exc)
            {
                
                walls++;
                x = xRight;
                y = yRight;
            }

        }
        static void Main(string[] args)
        {
            matrix = new char[4][];

            for (int a = 0; a < matrix.Length; a++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                matrix[a] = input;
            }
            char[] moves = Console.ReadLine().ToCharArray();
            DoMoves(moves);

            Console.WriteLine("Coins collected {0}", coins);
            Console.WriteLine("Walls hit {0}", walls); 
 
        }
    }
}
