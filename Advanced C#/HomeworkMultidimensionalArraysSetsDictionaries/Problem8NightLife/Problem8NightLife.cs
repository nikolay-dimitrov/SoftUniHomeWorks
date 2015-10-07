﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8NightLife
{
    class Problem8NightLife
    {
        static void Main(string[] args)
        {
            var schedule = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
            FillDictionary(schedule);
            Print(schedule);
        }

        static void FillDictionary(Dictionary<string, SortedDictionary<string, SortedSet<string>>> schedule)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] splitInput = input.Split(';');
                string city = splitInput[0];
                string club = splitInput[1];
                string performer = splitInput[2];
                var performers = new SortedSet<string>() { performer };
                var clubs = new SortedDictionary<string, SortedSet<string>>() { { club, performers } };

                if (!schedule.Keys.Contains(city))
                {
                    schedule.Add(city, clubs);
                }
                else
                {
                    if (!schedule[city].Keys.Contains(club))
                    {
                        schedule[city].Add(club, performers);
                    }
                    else
                    {
                        schedule[city][club].Add(performer);
                    }
                }
                input = Console.ReadLine();
            }
        }

        private static void Print(Dictionary<string, SortedDictionary<string, SortedSet<string>>> schedule)
        {
            foreach (var dict in schedule)
            {
                Console.WriteLine(dict.Key);
                foreach (var set in dict.Value)
                {
                    Console.Write("->{0}: ", set.Key);
                    Console.WriteLine(String.Join(", ", set.Value));
                }
            }
        }
    }
}
