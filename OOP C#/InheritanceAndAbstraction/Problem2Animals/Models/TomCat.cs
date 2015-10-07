using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2Animals.Models
{
    class TomCat : Cat
    {
        public TomCat(string name, int age)
            : base(name, age, "male")
        {
        }
    }
}
