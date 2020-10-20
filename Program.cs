using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            do { 
                Console.WriteLine("Bienvenue dans Computer Center que voulez vous faire ?");
                Console.WriteLine("1: Ajouter un ordinateur, 2: Supprimer un ordinateur, 3: Rechercher un ordinateur, 4: Modifier un ordinateur, 5: Sortir");
                string choix = Console.ReadLine();
            


                /* Console.WriteLine("Entrez un nombre");
                 String saisie = Console.ReadLine();
                 */
                double nombre = double.Parse(choix);

                Console.WriteLine("Vous avez saisie le choix N°: " + nombre);




                Computer myFirstComputer = new Computer();
                Computer myFirstComputer1 = new Computer();
                myFirstComputer.Id = 1;
                myFirstComputer.Brand = "ASUS";
                myFirstComputer.Model = "ROGUE";
                myFirstComputer.CPUFrequency = 2.4;
                myFirstComputer.RAM = 800000000000;
                myFirstComputer1.Id = 2;
                myFirstComputer1.Brand = "ASUS";
                myFirstComputer1.Model = "ROGUE";
                myFirstComputer1.CPUFrequency = 2.4;
                myFirstComputer1.RAM = 800000000000;
                List<Computer> myList = new List<Computer>();
                myList.Add(myFirstComputer);
                myList.Add(myFirstComputer1);



                switch (nombre)
                {
                    case 1:
                        
                        Console.WriteLine("Vous avez choisis d'ajouter un PC ");
                        //Computer Pc = new Computer();
                       // Pc.Id = myList.Count()+1; 
                        Console.WriteLine("Quelle est la marque que vous voulez ajouter ? ");
                        string brands = Console.ReadLine();
                       // Pc.Brand = brands; 
                        Console.WriteLine("Quelle est la modèle que vous voulez ajouter ? ");
                        string model = Console.ReadLine();
                       // Pc.Model = model;
                        Console.WriteLine("Quelle est la Fréquence du CPU ? ");
                        string CPUFS = Console.ReadLine();
                        double CPUF = double.Parse(CPUFS);
                       // Pc.CPUFrequency = CPUF;                        
                        Console.WriteLine("Quelle est la quantitié de RAM ? ");
                        string Rams = Console.ReadLine();
                        double Ram = double.Parse(Rams);
                       // Pc.RAM = Ram;

                        myList.Add(new Computer() {Id= myList.Count()+1, Brand=brands,Model=model,CPUFrequency=CPUF,RAM=Ram });
                        break;
                    case 2:
                        Console.WriteLine("Vous avez choisis de supprimer un PC ");
                        Console.WriteLine("Quelle est l'identifiant du PC a supprimer");
                        string Idsuppr = Console.ReadLine();
                        int IdsupprPc = int.Parse(Idsuppr);
                        myList.RemoveAt(IdsupprPc-1);
                        break;

                    case 3:
                        Console.WriteLine("Quelle est l'identifiant du PC rechercher ? ");
                        string saisie = Console.ReadLine();
                        int identifiant = int.Parse(saisie);
                        Console.WriteLine("Vous allez rechercher le PC avec pour identifiant: " + identifiant);

                        Console.WriteLine("identifiant " + myList[identifiant - 1].Id);
                        Console.WriteLine("Marque: " + myList[identifiant - 1].Brand);
                        Console.WriteLine("Modèle: " + myList[identifiant - 1].Model);
                        Console.WriteLine("Fréquence CPU: " + myList[identifiant - 1].CPUFrequency);
                        Console.WriteLine("RAM: " + myList[identifiant - 1].RAM);


                        break;
                    case 4:
                        Console.WriteLine("Vous avez choisis de modifier les caractéristiques un PC ");
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Votre choix ne correspond a aucun des choix possible");
                        break;
                }







                
            }
            while (Console.ReadLine()!="5");
           

            
        }
       
           
        
    public struct Computer
    {
        public long Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double CPUFrequency { get; set; }
        public double RAM { get; set; }
 
    }
      
    }
}
