using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>()
            {
                {"name", "Barbara"},
                {"age", "2"}
            });

            myFamily.Add("mother", new Dictionary<string, string>()
            {
                {"name", "Susan"},
                {"age", "64"}
            });

            myFamily.Add("father", new Dictionary<string, string>()
            {
                {"name", "Michael"},
                {"age", "67"}
            });

            foreach (var member in myFamily)
            {
                foreach (var person in member.Value)
                {
                    if (person.Key == "name")
                    {
                        Console.Write($"{person.Value} is my {member.Key} ");
                    }
                    else if (person.Key == "age")
                    {
                        Console.Write($"and is {person.Value} years old.");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
