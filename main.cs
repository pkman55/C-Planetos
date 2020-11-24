using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Sunkiojega
    {
        protected double menulis = 1.62;
        protected double zeme = 9.807;
        protected double marsas = 9.711;
        protected double venera = 8.87;
        protected double uranas = 8.87;
        protected double merkurijus = 3.7;
        public abstract double GetDiference();
    }
    class menulis : Sunkiojega
    {
        public override double GetDiference()
        {
            return zeme / menulis;
        }
    }
    class marsas : Sunkiojega 
    {
        public override double GetDiference()
        {
            return zeme / marsas;
        }
    }
    class venera : Sunkiojega
    {
        public override double GetDiference()
        {
            return zeme / venera;
        }
    }
    class uranas : Sunkiojega
    {
        public override double GetDiference()
        {
            return zeme / uranas;
        }
    }
    class merkurijus : Sunkiojega
    {
        public override double GetDiference()
        {
            return zeme / merkurijus;
        }
    }
    class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo svori (kg):");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite 0 baigti programą:\n");
            while (true)
            {
                
                
                Console.WriteLine("Iveskite pasirinkta planeta:");
                
                string planet = Console.ReadLine();
                switch (planet)
                {
                    case "Menulis":
                        {
                            menulis menulis = new menulis();
                            Console.WriteLine("Žemės sunkio jėga yra " + Math.Round(menulis.GetDiference(), 1) + " kartų didesnė nei Mėnulio.");
                            Console.WriteLine("Jūsų svoris Mėnulyje būtų: " + Math.Round((weight / menulis.GetDiference()), 2));
                            
                            break;
                        }
                    case "Marsas":
                        {
                            marsas marsas = new marsas();
                            Console.WriteLine("Žemės sunkio jėga yra " + Math.Round(marsas.GetDiference(), 1) + " kartų didesnė nei Marso.");
                            Console.WriteLine("Jūsų svoris Marse būtų: " + Math.Round((weight / marsas.GetDiference()), 2));

                            break;
                        }
                    case "Venera":
                        {
                            venera venera = new venera();
                            Console.WriteLine("Žemės sunkio jėga yra " + Math.Round(venera.GetDiference(), 1) + " kartų didesnė nei Veneros.");
                            Console.WriteLine("Jūsų svoris Veneroj būtų: " + Math.Round((weight / venera.GetDiference()), 2));

                            break;
                        }
                    case "Uranas":
                        {
                            uranas uranas = new uranas();
                            Console.WriteLine("Žemės sunkio jėga yra " + Math.Round(uranas.GetDiference(), 1) + " kartų didesnė nei Urano.");
                            Console.WriteLine("Jūsų svoris Urane būtų: " + Math.Round((weight / uranas.GetDiference()), 2));

                            break;
                        }
                    case "Merkurijus":
                        {
                            merkurijus merkurijus = new merkurijus();
                            Console.WriteLine("Žemės sunkio jėga yra " + Math.Round(merkurijus.GetDiference(), 1) + " kartų didesnė nei Merkurijaus.");
                            Console.WriteLine("Jūsų svoris Merkurijuje būtų: " + Math.Round((weight / merkurijus.GetDiference()), 2));

                            break;
                        }
                    case "0":
                        return;
                    default:
                    {
                        Console.WriteLine("Nera tokios planetos");
                        break;
                    }
                        
                }
            }
            

        }
    }
}
