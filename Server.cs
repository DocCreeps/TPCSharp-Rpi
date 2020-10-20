using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpcsharp
{
    class Server : Computer
    {
        public int bayNumber { get; set; }
        public int raid { get; set; }

        public Server() { }
        public Server(long Id, string Brand, string Model, double CPUFrequency, double RAM, Boolean Status, int bayNumber, int raid) : base(Id, Brand, Model, CPUFrequency, RAM, Status)
        {
            this.bayNumber = bayNumber;
            this.raid = raid;

        }
        public void backup()
        {
            Console.WriteLine("Sauvegarde éffectuer ");
        }

    }
}
