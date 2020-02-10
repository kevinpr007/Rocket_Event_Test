using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket_Event_Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rocket r1 = new Rocket("Rocket #1");

            Base base1 = new Base("Base #1", "Puerto Rico");
            base1.Subscribe(r1);

            Base base2 = new Base("Base #2", "USA");
            base2.Subscribe(r1);
            //asgdhasgd
            Console.WriteLine();
            r1.initialize();

            Console.WriteLine();
            r1.launch();

            Console.WriteLine();
            r1.traveling();

            Console.ReadKey();
        }
    }
}
