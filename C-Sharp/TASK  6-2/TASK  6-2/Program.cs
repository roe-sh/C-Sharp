using System;

namespace TASK__6_2
{
    //--------------------------- interface ISound-----------------------//
    //-------------------------------------------------------------------//
    public interface ISound
    {
        void MakeSound();

    }


    //--------------------------- class Animal-------------------------//
    //-------------------------------------------------------------------//

    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Eat();

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }

    //--------------------------- class Dog -------------------------//
    //-------------------------------------------------------------------//
    public class Dog : Animal, ISound
    {
        public Dog(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating dog food.");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }
    //--------------------------- class Cat -------------------------//
    //-------------------------------------------------------------------//
    public class Cat : Animal, ISound
    {
        public Cat(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating cat food.");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }
    //-------------------------------- class Program----------------------//
    //-------------------------------------------------------------------//
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Buddy");
            Cat cat = new Cat("Whiskers");

            dog.Eat();
            dog.Sleep();
            dog.MakeSound();

            cat.Eat();
            cat.Sleep();
            cat.MakeSound();
        }
    }
}
