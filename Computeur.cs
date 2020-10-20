using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpcsharp
{
    class Computer
    {

        public long Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double CPUFrequency { get; set; }
        public double RAM { get; protected set; }

        public Boolean Status { get; set; }

        public Computer() { }
        public Computer(long Id, string Brand, string Model, double CPUFrequency, double RAM, Boolean Status)
        {
            this.Id = Id;
            this.Brand = Brand;
            this.Model = Model;
            this.CPUFrequency = CPUFrequency;
            this.RAM = RAM;
            this.Status = Status;
        }
        public void start()
        {
            Console.WriteLine("Bonjour, bienvenue sur votre PC");
        }
        public void halt()
        {

            Console.WriteLine("Votre PC va s'éteindre ");
        }
    }
}

