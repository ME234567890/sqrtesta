using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
          //begining part
        
            string S_origininp = Console.ReadLine();
            int I_inp = int.Parse(S_origininp);
            int i = 0;
            while (!(Math.Abs(I_inp) < (i * i)))
            {
                i = i + 1;
            }
            int i2 = i - 1;
            int I_numerator = Math.Abs(I_inp) - (i2 * i2);
            int I_denom = (i * i) - (i2 * i2);
            Console.WriteLine("");
            Console.WriteLine(i2);
            if (! (I_numerator == 0))
                {
                Console.WriteLine("*");
                Console.WriteLine(I_numerator);
                Console.WriteLine("/");
                Console.WriteLine(I_denom);
            }
            Console.Write("");



            //ze loop


            while (true)
            {
                S_origininp = Console.ReadLine();
                I_inp = int.Parse(S_origininp);
                i = 0;
                while (!(Math.Abs(I_inp) < (i * i)))
                {
                    i = i + 1;
                }
                i2 = i - 1;
                I_numerator = Math.Abs(I_inp) - (i2 * i2);
                I_denom = (i * i) - (i2 * i2);
                Console.WriteLine("");
                Console.WriteLine(i2);
                if (!(I_numerator == 0))
                {
                    Console.WriteLine("*");
                    Console.WriteLine(I_numerator);
                    Console.WriteLine("/");
                    Console.WriteLine(I_denom);
                }
                Console.Write("");
                }
        }
    }
}
