using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr7
{
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif

            Konus p1, p2;

#if DEBUG
            p2 = new Konus(10.2, 16.7, 12, 8);
            p2.Info(ConsoleColor.Yellow, ConsoleColor.DarkBlue);
#endif

#if !DEBUG
            p1 = Konus.CreateKFF();
            p1.Info();
            p2 = new Konus(10.2, 16.7, 12, 8);
            p2.Info();
#endif

#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#endif
#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
