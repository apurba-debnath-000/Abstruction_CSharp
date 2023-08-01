using System;


namespace Abstruction
{
    internal class Dog:Animal, IAnimal
    {
        //First letter of Property name must be Capital.
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override string Color { get; set; }

        public Dog(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }
        public override void displayData()
        {
            Console.WriteLine($"Dog's name = {this.Name}");
            Console.WriteLine($"Dog's age = {this.Age}");
            Console.WriteLine($"Dog's color = {this.Color}");
        }
        public override void sound()
        {
            
            Console.WriteLine("Gew Ghweh..I am barking--");
            base.speakLoudly();
            this.Walking();
            this.Jumping();
            this.AnimalSound();
            Console.WriteLine("--------------");
        }

        public void AnimalSound()
        {
            Console.WriteLine("Amar sound holo ghew ghew kora.");
        }
        public void Jumping()
        {
            Console.WriteLine("Ami jump dite pari..");
        }

        public void Walking()
        {
            Console.WriteLine("Ami hatte pari to..");
        }
    }
}
