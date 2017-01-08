using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Be sure to go to "Project>Add Reference>[x]System.Numerics"
using System.Numerics;

namespace CSharpTutBigIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger bigNum = BigInteger.Parse("123451234512345123451234512345");
            Console.WriteLine("Big Number * 2 = {0}", bigNum * 2);

            Console.ReadLine();
        }
    }
}
