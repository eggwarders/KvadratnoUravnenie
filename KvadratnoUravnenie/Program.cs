using KvadratnoUravnenie.Controller;
using KvadratnoUravnenie.Model;
using KvadratnoUravnenie.View;
namespace KvadratnoUravnenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display display = new Display();
            ZadachaController controller = new ZadachaController(display);
            controller.Run();

        }
    }
}
