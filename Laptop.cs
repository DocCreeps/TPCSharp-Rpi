using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpcsharp
{
    class Laptop : Computer
    {
        public double screen { get; private set; }
        public double batteryLoad { get; private set; }
        public Laptop() { }
        public Laptop(long Id, string Brand, string Model, double CPUFrequency, double RAM, Boolean Status, double screen, double batteryLoad) : base(Id, Brand, Model, CPUFrequency, RAM, Status)
        {
            this.screen = screen;
            this.batteryLoad = batteryLoad;

        }
        public void sleep()
        {
            Console.WriteLine("mise en veille");
        }
        public void load()
        {
            Console.WriteLine("chargement");
        }

    }
}
