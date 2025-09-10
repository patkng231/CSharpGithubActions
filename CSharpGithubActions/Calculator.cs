using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGithubActions
{
    public class Calculator
    {
        public Calculator() 
        { 

        }
        
        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        public static int Remainder(int x, int y)
        {
            return x % y;
        }
    }
}
