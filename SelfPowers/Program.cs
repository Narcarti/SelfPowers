using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SelfPowers
{
    class Program
    {
        static void Main(string[] args)
        {

            UInt64 start = 1;

            BigInteger sum = 0;

            for (int basePow = 1; basePow < 1000; basePow++)
            {
                sum += BigInteger.Pow(basePow, basePow);
            }

            string last10 = "";
            string Ssum = sum.ToString();
            int length = Ssum.Length;
            last10 = sum.ToString().Substring(length - 10);

            Console.WriteLine(last10);

            Console.ReadLine();
        }
        
    }

}
