using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpcsharp
{
  /*  public struct Computer
    {
        public long Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double CPUFrequency { get; set; }
        public double RAM { get; set; }
    }
    */

    class Program
    {
        public static void displayComputer(Computer computer)
        {
            Console.WriteLine();
            Console.WriteLine("Id : " + computer.Id);
            Console.WriteLine("Brand : " + computer.Brand);
            Console.WriteLine("Model : " + computer.Model);
            Console.WriteLine("CPU Frequency : " + computer.CPUFrequency);
            Console.WriteLine("RAM : " + computer.RAM);
        }
        public static void displayLaptop(Laptop laptop)
        {
            Console.WriteLine();
            Console.WriteLine("Id : " + laptop.Id);
            Console.WriteLine("Brand : " + laptop.Brand);
            Console.WriteLine("Model : " + laptop.Model);
            Console.WriteLine("CPU Frequency : " + laptop.CPUFrequency);
            Console.WriteLine("RAM : " + laptop.RAM);
            Console.WriteLine("Scren:" + laptop.screen);
            Console.WriteLine("batteryLoad:" + laptop.batteryLoad);
        }
        public static void displayServer(Server server)
        {
            Console.WriteLine();
            Console.WriteLine("Id : " + server.Id);
            Console.WriteLine("Brand : " + server.Brand);
            Console.WriteLine("Model : " + server.Model);
            Console.WriteLine("CPU Frequency : " + server.CPUFrequency);
            Console.WriteLine("RAM : " + server.RAM);
            Console.WriteLine("BayNumber : " + server.bayNumber);
            Console.WriteLine("Raid : " + server.raid);

        }


        public static Computer setComputer(Computer computer)
        {
            Console.WriteLine("Brand : ");
            computer.Brand = Console.ReadLine();
            Console.WriteLine("Model : ");
            computer.Model = Console.ReadLine();
            Console.WriteLine("CPU Frequency : ");
            computer.CPUFrequency = double.Parse(Console.ReadLine());
          /*  Console.WriteLine("RAM : ");
            computer.RAM = double.Parse(Console.ReadLine());*/
            return computer;
        }
        public static Laptop setLaptop(Laptop laptop)
        {
            Console.WriteLine("Brand : ");
            laptop.Brand = Console.ReadLine();
            Console.WriteLine("Model : ");
            laptop.Model = Console.ReadLine();
            Console.WriteLine("CPU Frequency : ");
            laptop.CPUFrequency = double.Parse(Console.ReadLine());
          /*  Console.WriteLine("RAM : ");
             lomputer.RAM = double.Parse(Console.ReadLine());
            Console.WriteLine("écran en pouce ? ");
            laptop.screen = int.Parse(Console.ReadLine());
            Console.WriteLine("Chargement ? ");
            laptop.load= int.Parse(Console.ReadLine());*/
            return laptop;
        }
        public static Server setServer(Server server)
        {
            Console.WriteLine("Brand : ");
            server.Brand = Console.ReadLine();
            Console.WriteLine("Model : ");
            server.Model = Console.ReadLine();
            Console.WriteLine("CPU Frequency : ");
            server.CPUFrequency = double.Parse(Console.ReadLine());
            /* Console.WriteLine("RAM : ");
              computer.RAM = double.Parse(Console.ReadLine());*/
            Console.WriteLine("bayNumber : ");
            server.bayNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("raid : ");
            server.raid = int.Parse(Console.ReadLine());
            return server;
        }
        static void Main(string[] args)
        {
           /* Computer newComputeur = new Computer();
            Laptop newLaptop = new Laptop();
            Server newServer = new Server(); */

            Dictionary<long, Computer> ParkC = new Dictionary<long, Computer>();
           /* Dictionary<long, Laptop> ParkL = new Dictionary<long, Laptop>();
            Dictionary<long, Server> ParkS = new Dictionary<long, Server>();*/
            long NextId;

           /* Computer computer1 = new Computer();
            computer1.Id = 1;
            computer1.Brand = "Apple";
            computer1.Model = "MacBook Pro";
            computer1.CPUFrequency = 2.4;
            computer1.RAM = 8;

            Computer computer2 = new Computer();
            computer2.Id = 2;
            computer2.Brand = "Toshiba";
            computer2.Model = "Satellite Pro";
            computer2.CPUFrequency = 2;
            computer2.RAM = 8;

            Computer computer3 = new Computer();
            computer3.Id = 3;
            computer3.Brand = "Asus";
            computer3.Model = "Zephyrus";
            computer3.CPUFrequency = 1.2;
            computer3.RAM = 4;

            Park.Add(computer1.Id, computer1);
            Park.Add(computer2.Id, computer2);
            Park.Add(computer3.Id, computer3);
            */
            string choix;
            NextId = 4;

            do
            {
                Console.WriteLine("Que voulez-vous faire ? ");
                Console.WriteLine("1 - Afficher le parc informatique");
                Console.WriteLine("2 - Ajouter un ordinateur");
                Console.WriteLine("3 - Supprimer un ordinateur");
                Console.WriteLine("4 - Rechercher un ordinateur");
                Console.WriteLine("5 - Modifier un ordinateur");
                Console.WriteLine("6 - Ajouter un Laptop");
                Console.WriteLine("7 - Ajouter un Server");
                Console.WriteLine("quit - Quitter");

                choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        Console.WriteLine("Parc informatique");
                        Console.WriteLine("Les PC");
                        foreach (KeyValuePair<long, Computer> idComputerPair in ParkC)
                        {
                            displayComputer(idComputerPair.Value);
                            
                        }
                       /* Console.WriteLine("Les Laptop");
                        foreach (KeyValuePair<long, Laptop> idLaptopPair in ParkL)
                        {
                            displayComputer(idLaptopPair.Value);
                        }
                        Console.WriteLine("Les Servers");
                        foreach (KeyValuePair<long, Server> idServerPair in ParkS)
                        {
                            displayComputer(idServerPair.Value);
                        }*/
                        break;
                    case "2":
                        Console.WriteLine("Ajout d'ordinateur:");
                        Computer newComputer = new Computer();
                        newComputer.Id = NextId;
                        NextId++;
                        newComputer = setComputer(newComputer);
                        ParkC.Add(newComputer.Id, newComputer);
                        break;
                    case "3":
                        Console.WriteLine("Suppression d'ordinateur:");
                        Console.WriteLine("Indiquez le numéro de l'ordinateur que vous voulez supprimer :");
                        long IdDelete = long.Parse(Console.ReadLine());
                        ParkC.Remove(IdDelete);
                        break;
                    case "4":
                        Console.WriteLine("Recherche d'ordinateur:");
                        Console.WriteLine("Id ?");
                        long IdSearch = long.Parse(Console.ReadLine());
                        displayComputer(ParkC[IdSearch]);
                        break;
                    case "5":
                        Console.WriteLine("Modification d'ordinateur:");
                        Console.WriteLine("Id ?");
                        long IdModify = long.Parse(Console.ReadLine());
                        ParkC[IdModify] = setComputer(ParkC[IdModify]);
                        break;
                    case "6":
                        Console.WriteLine("Ajout d'un Laptop:");
                        Laptop newLaptop = new Laptop();
                        newLaptop.Id = NextId;
                        NextId++;
                        newLaptop = setLaptop(newLaptop);
                        ParkC.Add(newLaptop.Id, newLaptop);
                        break;
                    case "7":
                        Console.WriteLine("Ajout d'un Server:");
                        Server newServer = new Server();
                        newServer.Id = NextId;
                        NextId++;
                        newServer = setServer(newServer);
                        ParkC.Add(newServer.Id, newServer);
                        break;
                    case "quit":
                        Console.WriteLine("Extinction");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Choix non reconnu, saisissez un nombre 1 et 5");
                        break;
                }
            } while (choix != "quit");



        }
    }
}
