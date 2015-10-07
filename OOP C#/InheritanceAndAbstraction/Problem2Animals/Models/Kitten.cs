using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2Animals.Models
{
    class Kitten :Cat
    {
        public Kitten (string name,int age) : base (name,age,"female")
        {
        }
    }
}
