using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KvadratnoUravnenie.Model;
using KvadratnoUravnenie.View;

namespace KvadratnoUravnenie.Controller
{
    public class ZadachaController
    {
        Display display;

        public void Calculate()
        {
            double d = Math.Pow(display.data.B, 2) + (-4 * display.data.A * display.data.C); 
            if(d < 0)
                throw new Exception("negativna diskrimanta");
            else
                if(d==0)    //x1=x2
            {
                display.data.X1 = -display.data.B / (2 * display.data.A);
                display.data.X2 = display.data.X1;
            }
            else
            {
                display.data.X1 = ((double)-display.data.B + d) / (2 * (double)display.data.A);
                display.data.X2 = ((double)-display.data.B - d) / (2 * (double)display.data.A);
            }
        }
        public ZadachaController(Display display)
        {
            this.display = display;
        }

        public void GetInput()
        {
            display.GetValue();
        }
        public void ShowData()
        {
            display.ShowResult();
        }
        public void Run() 
        {
            GetInput();
            Calculate();
            ShowData();
        }
    }
}
