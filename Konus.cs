using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr7
{
    class Konus
    {
        private double h, r1, r2, l;

        private Konus() { }

        public Konus(double pH, double pR1, double pR2, double pL)
        {
            h = pH; r1 = pR1; r2 = pR2; l = pL;
        }

        private void Load()
        {
            h = Convert.ToDouble(Console.ReadLine());
            r1 = Convert.ToDouble(Console.ReadLine());
            r2 = Convert.ToDouble(Console.ReadLine());
            l = Convert.ToDouble(Console.ReadLine());
        }

        public static Konus CreateKFF()
        {
            double hh = Convert.ToDouble(Console.ReadLine());
            double r11 = Convert.ToDouble(Console.ReadLine());
            double r22 = Convert.ToDouble(Console.ReadLine());
            double ll = Convert.ToDouble(Console.ReadLine());
            return new Konus(hh, r11, r22, ll);
        }

        public double GetV() { return 1 / 3 * Math.PI * h * (Math.Pow(r1, 2) + r1 * r2 + Math.Pow(r2, 2)); }

        public double GetS() { return Math.PI * l * (r1 + r2); }

        public void Info()
        {
            String str = "KONUS";
            Console.WriteLine(str);
            Console.WriteLine(string.Format("H = {0:0.00}, r1 = {0:0.00}, r2 = {0:0.00}, l = {0:0.00}", h, r1, r2, l));
            Console.WriteLine(string.Format("V = {0:0.00}", GetV()));
            Console.WriteLine(string.Format("S = {0:0.00}", GetS()));
            
        }

        public void Info(ConsoleColor fg, ConsoleColor bgc) {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bgc;
            Info();
        }
    }
}
