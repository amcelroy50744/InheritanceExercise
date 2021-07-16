using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird robin = new Bird();
            robin.AnimalKingdom = "Animalia";
            robin.BirdName = "Robin";
            robin.CanITRun = true;
            robin.Class = "Aves";
            robin.HasFeathers = true;
            robin.Phylum = "Chordata";
            robin.ItcanFly = true;

            var mybird = new Animals[] { robin };

            foreach (var Animals in mybird) 
            {
                Console.WriteLine(Animals.AnimalKingdom);
                Console.WriteLine(robin.BirdName);
                Console.WriteLine(robin.CanITRun);
            }


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
