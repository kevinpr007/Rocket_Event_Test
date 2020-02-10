using System;

namespace Rocket_Event_Test
{
    public class Rocket
    {
        public delegate void RocketMessage(Object o, EventArgs e);

        public event RocketMessage MyRocketMessage;
        public event EventHandler newEvent;

        public string Name { get; set; }
        public int FuelCapacity { get; set; }

        public Rocket(string name)
        {
            this.Name = name;
            Console.WriteLine(String.Format("Rocket: Creating a New Rocket called {0}...", Name));
        }

        public void initialize()
        {
            Console.WriteLine("Rocket: Initializing...");
            this.FuelCapacity = 5;
            MyRocketMessage("Initialized", EventArgs.Empty);
            //newEvent("newEvent: Initialized", EventArgs.Empty);
        }

        public void launch()
        {
            int consumingFuel = 1;

            Console.WriteLine("Rocket: Starting...");
            FuelCapacity = FuelCapacity - consumingFuel;
            MyRocketMessage("Started Event", EventArgs.Empty);
            //newEvent("::newEvent::", EventArgs.Empty);
        }

        public void traveling()
        {
            int OriginalFuel = FuelCapacity;

            Console.WriteLine("Rocket: Traveling...");
            MyRocketMessage("Traveling Event", EventArgs.Empty);
            while ( FuelCapacity > 0)
            {
                Console.WriteLine(String.Format("Rocket: Consuming fuel... Remaining {0} of {1}", FuelCapacity, OriginalFuel));
                --FuelCapacity;
                MyRocketMessage(String.Format("Sending Remaining fuel Event: {0}", FuelCapacity), EventArgs.Empty);
            }
            stop();
        }

        public void stop()
        {
            Console.WriteLine("Rocket: Stopping...");
            MyRocketMessage("Stopped Event", EventArgs.Empty);
        }
    }
}
