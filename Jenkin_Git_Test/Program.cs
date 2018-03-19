using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenkin_Git_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
                Console.WriteLine("Main: Jenkins - MSBuild - :" + i);
            Console.ReadKey();
        }
    }
}
