using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_01
{
    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    public class Lion : Animal
    {
        public override void MakeSound()
        {
            Console.Write("Lion Roars");
        }
    }

    public class Tiger : Animal
    {
        public override void MakeSound()
        {
            Console.Write("Tiger Growls");
        }
    }

    public class Elephant : Animal
    {
        public override void MakeSound()
        {
            Console.Write("Elephant Trumpets");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            Console.WriteLine("ZOO MANAGEMENT SYSTEM");

            while (true)
            {
                Console.WriteLine("1. Add Lion");
                Console.WriteLine("2. Add Tiger");
                Console.WriteLine("3. Add Elephant");
                Console.WriteLine("4. Exit Zoo");
                Console.WriteLine("Enter you choice: ");
                
                int selectedAnimal;
                while (!int.TryParse(Console.ReadLine(), out selectedAnimal) || selectedAnimal < 1 || selectedAnimal > 4)
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice (1-4): ");
                }

                Animal animalSound = null;
                string animalType = null;

                switch (selectedAnimal)
                {
                    case 1:
                        animalSound = new Lion();
                        animalType = "Lion";
                        break;
                    case 2:
                        animalSound = new Tiger();
                        animalType = "Tiger";
                        break;
                    case 3:
                        animalSound = new Elephant();
                        animalType = "Elephant";
                        break;
                    case 4:
                        Console.WriteLine("Exiting Zoo Management System...");
                        Console.ReadLine();
                        return;
                }

                animals.Add(animalSound);
                Console.WriteLine($"\n{animalType} added!");

                Console.Write($"Sound of {animalType}: ");

                foreach (Animal animal in animals)
                {
                    animal.MakeSound();
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
