using CSharpGithubActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class UnitTest2
    {
        private Person Person;

        public UnitTest2() 
        {
            Person = new Person("Patrick", 27);
        }

        [Fact]
        public void UpdateAgeTest()
        {
            Person.UpdateAgeByOne();

            Assert.True(Person.GetAge() == 28);
        }

        [Fact]
        public void CheckName()
        {
            Assert.True(Person.Name == "Patrick");
        }

        [Fact]
        public void CheckIncorrectName()
        {
            Assert.False(Person.Name == "Ryan");
        }
    }
}
