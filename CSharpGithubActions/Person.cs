using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGithubActions
{
    public class Person
    {
        public readonly string Name;
        private int Age;
        public Person(string name, int age) 
        {
            Name = name;
            Age = age;
        }

        public string PrintPerson()
        {
            return $"{Name}:{Age}";
        }

        public void UpdateAgeByOne()
        {
            Age += 1;
        }

        public int GetAge() => Age;
    }
}
