using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Bases
{
    public struct Computer
    {
        public long Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double CPUFrequency { get; set; }
        public double RAM { get; set; }
    }


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

        public static Computer setComputer(Computer computer)
        {
            Console.WriteLine("Brand : ");
            computer.Brand = Console.ReadLine();
            Console.WriteLine("Model : ");
            computer.Model = Console.ReadLine();
            Console.WriteLine("CPU Frequency : ");
            computer.CPUFrequency = double.Parse(Console.ReadLine());
            Console.WriteLine("RAM : ");
            computer.RAM = double.Parse(Console.ReadLine());
            return computer;
        }
        static void Main(string[] args)
        {
            Dictionary<long, Computer> Park = new Dictionary<long, Computer>();
            long NextId;

            Computer computer1 = new Computer();
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

            string saisie;
            NextId = 4;

            do
            {
                
                Console.WriteLine("Que voulez-vous faire ? ");
                Console.WriteLine("1 - Afficher le parc informatique");
                Console.WriteLine("2 - Ajouter un ordinateur");
                Console.WriteLine("3 - Supprimer un ordinateur");
                Console.WriteLine("4 - Rechercher un ordinateur");
                Console.WriteLine("5 - Modifier un ordinateur");
                Console.WriteLine("6 - Quitter");

                saisie = Console.ReadLine();
                int choix = int.Parse(saisie);
                switch (choix)
                {
                    case 1:
                        Console.WriteLine("Parc informatique");
                        foreach (KeyValuePair<long, Computer> idComputerPair in Park)
                        {
                            displayComputer(idComputerPair.Value);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ajout d'ordinateur:");
                        Computer newComputer = new Computer();
                        newComputer.Id = NextId;
                        NextId++;
                        newComputer = setComputer(newComputer);
                        Park.Add(newComputer.Id, newComputer);
                        break;
                    case 3:
                        Console.WriteLine("Suppression d'ordinateur:");
                        Console.WriteLine("Indiquez le numéro de l'ordinateur que vous voulez supprimer :");
                        long IdDelete = long.Parse(Console.ReadLine());
                        Park.Remove(IdDelete);
                        break;
                    case 4:
                        Console.WriteLine("Recherche d'ordinateur:");
                        Console.WriteLine("Quelle est l' Id ? ");
                        long IdSearch = long.Parse(Console.ReadLine());
                        displayComputer(Park[IdSearch]);
                        break;
                    case 5:
                        Console.WriteLine("Modification d'ordinateur:");
                        Console.WriteLine("Quelle est l' Id ? ");
                        long IdModify = long.Parse(Console.ReadLine());
                        Park[IdModify] = setComputer(Park[IdModify]);
                        break;
                    case 6:
                        Console.WriteLine("Extinction");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Choix non reconnu, saisissez un nombre 1 et 5");
                        break;
                }
            } while (choix != 6);


            ;
        }
    }
}
