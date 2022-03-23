using System;

namespace InheritanceDemo
{
    /// <summary>
    /// Firstly create ILandBound as an interface that defines an object to be used later in the classes
    /// </summary>
    interface ILandBound
    {
        int NumberOfLegs();
    }
    /// <summary>
    /// Then we create the class Mammal which will be the base class....
    /// </summary>
    class Mammal
    {
        public void Breathe()
        {
            Console.WriteLine("All mammals breathe ");
        }
        public void SuckleYoung()
        {
            Console.WriteLine("All mammals suckle their young \n");
        }
    }
    /// <summary>
    /// Then declare derived classes for different types of mammals that have methods unique to that type of animal
    /// The horse class also inherits from the ILandBound interface
    /// </summary>
    class Horse : Mammal, ILandBound
    {
        int ILandBound.NumberOfLegs()
        { 
            return 4; 
        }
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

            //The ILandBound interface must be explicitly implemented.
            ILandBound landBound = myHorse;
            int legsOnHorse = landBound.NumberOfLegs();
            Console.WriteLine("A horse has " + legsOnHorse + " legs.");

            myHorse.Trot();
            Console.WriteLine("\n");
            Whale myWhale = new Whale();
            
            myWhale.Breathe();
            myWhale.SuckleYoung();
            myWhale.Swim();
        }
    }

   
}
