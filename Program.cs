using System;
using System.Collections.Generic;

namespace assign3_inherit
{
    abstract class Animal
    {
        public string color { get; set; }
        public string breed { get; set; }
        public string NoOfSpikes { get; set; }
        public string IsPoisonous { get; set; }
        public string Wingspan { get; set; }
        public string typeofwolf { get; set; }
        public string type { get; set; }
        public string species { get; set; }
        public string blacknecked { get; set; }

        public abstract void DoSound();

        public void CreateAnimal(string color, string breed, double NoOfSpikes, bool IsPoisonous, double Wingspan, string typeofwolf, string type, string species, bool blacknecked)
        {
        }
        public abstract string Stats();
    }


    class Horse : Animal
    {
        public string color { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("The horse says: neigh neigh");
        }
        public override string Stats()
        {
            return color;
        }

    }
    class Dog : Animal
    {

        public string breed; 
        public override void DoSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The dog says: bark bark");
        }
        public override string Stats()
        {
            return breed;
        }
    }
    class Hedgehog : Animal
    {
        public string NoOfSpikes;
        public override void DoSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The hedgehog says: quack quack");
        }
        public override string Stats()
        {
            return NoOfSpikes;
        }
    }
    class Worm : Animal
    {
        public string IsPoisonous = "yes";
        
        public override void DoSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The worm says: hiss hiss");
        }
        public override string Stats()
        {
            return IsPoisonous;
            
        }
    }
    class Bird : Animal
    {
        public string Wingspan { get; set; }
        public override void DoSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The bird says: chip chip");
        }
        public override string Stats()
        {
            return Wingspan;
        }
    }
    class Wolf : Animal
    {
        public string typeofwolf { get; set; }
        public override void DoSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The wolf says: howl howl");
        }
        public override string Stats()
        {
            return typeofwolf;
        }
    }
    class Pelican : Bird
    {
        public string type { get; set; }
        public override string Stats()
        {
            return type;
        }
    }

    class Flamingo : Bird
    {
        public string species;
        public override string Stats()
        {
            return species;
        }
    }


    class Swan : Bird
    {
        public string blacknecked { get; set; }
        public override string Stats()
        {
            return blacknecked;
        }
    }


    public interface IPerson
    {
        public string Talk();
    }
    class Wolfman : Wolf, IPerson
    {
        public string Talk() { return "Hi!"; }
    }

    public class Program
    {


        static void Main(string[] args)
        {
            //String animal1 = Console.ReadLine();
            //List<String> Animals = new List<String>();
            // Animals.Add(animal1);
            // String animal2 = Console.ReadLine();
            //Animals.Add(animal2);
            //foreach (var anim in Animals)
            //{
            //   Console.WriteLine(anim);
            //              }
            
            Dog dog = new Dog();
            dog.Stats();
            dog.DoSound();

            Console.WriteLine();

            Worm worm = new Worm();
            worm.DoSound();
            worm.Stats();


        }
}
}        
    


