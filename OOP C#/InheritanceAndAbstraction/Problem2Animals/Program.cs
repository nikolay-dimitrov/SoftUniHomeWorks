using Problem2Animals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Frog Goshko = new Frog("Goshko", 10, "male");
                Frog Dimitrur = new Frog("Dimitur",6, "male");
                Frog Minka = new Frog("Minka", 3, "female");

                Dog Rex = new Dog("Rex", 1, "male");
                Dog Hunter = new Dog("Hunter", 5, "male");
                Dog Blondie = new Dog("Blondie",3,"female");

                Kitten Puxy = new Kitten ("Puxy" , 2);
                Kitten Dazzy = new Kitten("Dazzy",5);
                Kitten Tuffy = new Kitten("Tuffy", 4);

                TomCat Tom = new TomCat("Tom", 4);
                TomCat Djeramaia = new TomCat("Djeramaia", 1);
                TomCat Virgin = new TomCat("Virgin",7);

                IList<Animal> animals = new List<Animal>
                {
                    Goshko,Dimitrur,Minka,Rex,Hunter,Blondie,Puxy,Dazzy,Tuffy,Tom,Djeramaia,Virgin
                };
                Goshko.ProduceSound();
                Rex.ProduceSound();
                Puxy.ProduceSound();
                Tom.ProduceSound();

                double catsAverageAge = animals
                    .Where(animal => animal is Cat)
                    .Average(cat => cat.Age);
                double dogsAverageAge = animals
                                    .Where(animal => animal is Dog)
                                    .Average(dog => dog.Age);

                double frogsAverageAge = animals
                    .Where(animal => animal is Frog)
                    .Average(frog => frog.Age);

                Console.WriteLine("Frogs average age is: {0:F2}", frogsAverageAge);
                Console.WriteLine("Dogs average age is: {0:F2}", dogsAverageAge);
                Console.WriteLine("Cats average age is: {0:F2}", catsAverageAge);

            }
            catch (ArgumentOutOfRangeException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (ArgumentNullException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}