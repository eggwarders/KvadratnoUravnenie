using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KvadratnoUravnenie.Model;

namespace KvadratnoUravnenie.View
{
    public class Display
    {
        public Data data = new Data();
        public void GetValue()
        {
            Console.Write("Input a = ");
            data.A = int.Parse(Console.ReadLine());
            Console.Write("Input b = ");
            data.B = int.Parse(Console.ReadLine());
            Console.Write("Input c = ");
            data.C = int.Parse(Console.ReadLine());
        }
        public void ShowResult() 
        {
            Console.WriteLine($"X1 = {data.X1:F2}   |   X2 = {data.X2}");
        }
    }
}

