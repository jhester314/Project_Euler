using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Tools
{
    public class Sequences
    {

        public BigInteger GetFibonacciTerm(int input)
        {
            BigInteger result = 0;
            if (input < 3)
            {
                result = 1;
            }
            else
            {
                BigInteger n_2 = 1;
                BigInteger n_1 = 1;
                result = 2;
                for (int i = 4; i <= input; i++)
                {
                    n_2 = n_1;
                    n_1 = result;
                    result = n_2 + n_1;
                }
            }

            return result;
        }

    }
}
