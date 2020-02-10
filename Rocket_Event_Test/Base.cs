using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket_Event_Test
{
    public class Base
    {
        public Rocket.RocketMessage MyRocketMessage;

        public string BaseName { get; set; }
        public string Location { get; set; }

        public Base(String name, String location)
        {
            this.BaseName = name;
            this.Location = location;
            Console.WriteLine(String.Format("Base: Creating a Base called {0} on {1}", BaseName, location));
        }
        public void Subscribe(Rocket r)
        {
            r.MyRocketMessage += new Rocket.RocketMessage(HeardIt);
            r.newEvent += new EventHandler(HeardIt);
        }

        private void HeardIt(Object r, EventArgs e)
        {
            System.Console.WriteLine(String.Format("{0} - {1}: {2}", Location, BaseName, r));
        }
    }
}
