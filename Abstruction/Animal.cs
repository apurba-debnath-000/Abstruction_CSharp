using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruction
{
    public abstract class Animal
    {

        // Abstract can have :
        //Abstract methode for overriden by child class.
        //Non-Abstract-methods
        private string name;
        private int age;
        private string color;

        public abstract string Name { set; get; }
        public abstract string Color { set; get; }
        public abstract int Age { set; get; }

        public abstract void sound();

        public abstract void displayData();

        public void speakLoudly() {
            Console.WriteLine("I could speak loudly!");
        }


    }
}
