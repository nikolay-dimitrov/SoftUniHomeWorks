using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                string str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    throw new ArgumentException();
                }
                int num = int.Parse(str);
                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                double result = Math.Sqrt(num);
                Console.WriteLine(result);
            }

            catch (ArgumentNullException ex)
            {
                Console.Error.WriteLine("Input must have a value!\n" + ex.ToString());
            }
            catch (FormatException fe)
            {
                Console.Error.WriteLine("Invalid format!\n" + fe.ToString());
            }
            catch (ArgumentOutOfRangeException or)
            {
                Console.Error.WriteLine("Input cannot take negative value!\n" + or.ToString());
            }

            catch (OverflowException oe)
            {
                Console.Error.WriteLine("Input exceeds the boundaries of the Int32 type!\n" + oe.ToString());
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
