using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOP
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', n + 1),
                new string('_', 2 * n + 1));

            for (int i = n; i > 0; i--)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', i),
                new string('_', 4 * n - 1 - 2 * i)
                    );

            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (4 * n - 6) / 2));
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', j),
                new string('_', 4 * n - 1 - 2 * j)
                    );


            }
        }
    }
}
