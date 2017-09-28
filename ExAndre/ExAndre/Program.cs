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
            int age1, age2, fatigue1 = 101, fatigue2 = 101;
            string name, pet, owner, language, IDE, race;
            Console.WriteLine("Lets make a Programmer! First off, what will his name be?");
            name = Console.ReadLine();
            owner = name;
            Console.WriteLine("Age?");
            age1 = Console.Read();

            do
            {
                Console.WriteLine("His fatigue level (from 0 to 100)?");
                fatigue1 = Console.Read();
            }while(fatigue1 > 100);

            Console.WriteLine("What language do you work on?");
            language = Console.ReadLine();
            Console.WriteLine("And finally, in what environment do you work on?");
            IDE = Console.ReadLine();
            Console.WriteLine("Lets make a pet now! What name will you give him?");
            pet = Console.ReadLine();
            Programmer humano = new Programmer(language, IDE, age1, fatigue1, name, pet);
            Console.WriteLine("How old is the poor fella?");
            age2= Console.Read();
            Console.WriteLine("What race?");
            race = Console.ReadLine();
            do
            {
                Console.WriteLine("And how tired is he (from 0 to 100)?");
                fatigue2= Console.Read();
            } while (fatigue > 100);

            Dog doggo = new Dog(race, age, fatigue, pet);

            do
            {
                Console.WriteLine("You want to do a action with the Human or the Pet?");
                string choice = Console.ReadLine();
                if (choice == "Human" || choice == "human")
                {
                    Console.WriteLine("And what action do you want to do? Sleep, Run, Play or Work?");
                    string action = Console.ReadLine();
                    if (action == "Sleep" || action == "sleep")
                    {
                        humano.Sleep();
                    }
                    else if (action == "Run" || action == "run")
                    {
                        humano.Run();
                    }
                    else if (action == "Play" || action == "Play")
                    {
                        Console.WriteLine("You want to play alone or with a dog?");
                        string dog = Console.ReadLine();
                        if (dog == "Alone" || dog == "alone")
                        {
                            humano.Play();
                        }
                        else if (dog == "Dog" || dog == "dog")
                        {
                            Console.WriteLine("You wish to play with your own dog or someone elses?");
                            string doggy = Console.ReadLine();
                            if (doggy == "Mine" || doggy == "mine")
                            {
                                humano.Play(doggo);
                            }
                            else if (doggy == "another" || doggy == "Another")
                            {
                                humano.Play();
                            }
                        }
                    }
                    else if (action == "Work" || action == "work")
                    {
                        humano.Work();
                    }
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

    }
}

