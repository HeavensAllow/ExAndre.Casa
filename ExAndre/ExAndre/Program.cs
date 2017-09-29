using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAndre
{
    class Program
    {
        static void Main(string[] args)
        {

            //Human h = new Human("mamifero", 10, "andre");
            //Programmer p = new Programmer("mamifero", 10, "andre", "c#", "visual studio");

            //Dog dog1 = new Dog("mamifero", 5, "bolinhas", "pitbull");
            //Dog dog2 = new Dog("mamifero", 2, "satan", "chihuahua");

            //h.Pet = dog1;

            //Console.ReadLine();

            Human[] humanArray = new Human[10];
            Pet[] petArray = new Pet[10];

            Console.WriteLine("1 - Menu humanos");
            Console.WriteLine("2 - Menu dogs");
            Console.WriteLine("3 - Sair do programma");

            // quando clicamos 1
            Console.WriteLine("1 - Criar novo humano");
            Console.WriteLine("2 - Editar humano");
            Console.WriteLine("3 - Apagar humano");
            Console.WriteLine("4 - Atribuir um cao a um humano");
            Console.WriteLine("5 - Voltar ao menu inicial")
;
            // Quando clicamos 2
            Console.WriteLine("1 - Criar novo cao");
            Console.WriteLine("2 - Editar cao");
            Console.WriteLine("3 - Apagar cao");
            Console.WriteLine("4 - Voltar ao menu inicial");

            //int age1, age2;
            //string name, pet, language, IDE, race;
            //Console.WriteLine("Lets make a Programmer! First off, what will his name be?");
            //name = Console.ReadLine();
            //Console.WriteLine("Age?");
            //age1 = Console.Read();
            //Console.WriteLine("What language do you work on?");
            //language = Console.ReadLine();
            //Console.WriteLine("And finally, in what environment do you work on?");
            //IDE = Console.ReadLine();
            //Console.WriteLine("Lets make a pet now! What name will you give him?");
            //pet = Console.ReadLine();
            //Console.WriteLine("How old is the poor fella?");
            //age2 = Console.Read();
            //Console.WriteLine("What race?");
            //race = Console.ReadLine();
            //Programmer humano = new Programmer(language, IDE, age1, name);
            //Dog doggo = new Dog(race, age2, pet);
            //    do
            //    {
            //        Console.WriteLine("You want to do a action with the Human or the Pet?");
            //        string choice = Console.ReadLine();
            //        if (choice == "Human" || choice == "human")
            //        {
            //            Console.WriteLine("And what action do you want to do? Sleep, Run, Play or Work?");
            //            string action = Console.ReadLine();
            //            if (action == "Sleep" || action == "sleep")
            //            {
            //                humano.Sleep();
            //            }
            //            else if (action == "Run" || action == "run")
            //            {
            //                humano.Run();
            //            }
            //            else if (action == "Play" || action == "Play")
            //            {
            //                Console.WriteLine("You want to play alone or with a dog?");
            //                string dog = Console.ReadLine();
            //                if (dog == "Alone" || dog == "alone")
            //                {
            //                    humano.Play();
            //                }
            //                else if (dog == "Dog" || dog == "dog")
            //                {
            //                    Console.WriteLine("You wish to play with your own dog or someone elses?");
            //                    string doggy = Console.ReadLine();
            //                    if (doggy == "Mine" || doggy == "mine")
            //                    {
            //                        humano.Play(doggo);
            //                    }
            //                    else if (doggy == "another" || doggy == "Another")
            //                    {
            //                        humano.Play();
            //                    }
            //                }
            //            }
            //            else if (action == "Work" || action == "work")
            //            {
            //                humano.Work();
            //            }
            //        }
            //    } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            //}

        }
    }
}

