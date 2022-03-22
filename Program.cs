using System;

namespace InheritanceDemo
{
    /// <summary>
    /// Firstly create Mammal as the base class containing methods that are common to all mammals
    /// </summary>
    class Mammal
    {
        public void Breathe()
        {
            Console.WriteLine("All mammals breathe \n");
        }

        public void SuckleYoung()
        {
            Console.WriteLine("All mammals suckle their young \n");
        }
    }

    /// <summary>
    /// Then declare derived classes for different types of mammals that have methods uniqu to that type of animal
    /// </summary>
    class Horse : Mammal
    {
        public void Trot()
        {
            Console.WriteLine("Horses also trot \n");
        }
    }

    class Whale : Mammal
    {
        public void Swim()
        {
            Console.WriteLine("Whales swim \n");
        }
    }

    /// <summary>
    /// The Program class contains the Main method which controls the flow of the program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            /* Let's start by creating a Horse object and calling all the methods applicable..*/

            Horse myHorse = new Horse();
            
            myHorse.Breathe();
            myHorse.SuckleYoung();
            myHorse.Trot();
            Console.WriteLine("\n");
            Whale myWhale = new Whale();
            
            myWhale.Breathe();
            myWhale.SuckleYoung();
            myWhale.Swim();
        }
    }

   
}
