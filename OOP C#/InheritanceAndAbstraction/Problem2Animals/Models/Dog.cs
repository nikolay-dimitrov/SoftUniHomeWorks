﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2Animals.Models
{
     class Dog : Animal
    {
         public Dog (string name,int age,string gender)
             : base(name,age,gender)
         {
         }
         public override void ProduceSound()
         {
             Console.WriteLine("BAU!!");
         }
    }
}
