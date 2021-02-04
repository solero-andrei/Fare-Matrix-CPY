using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Animal
    {
        public string sound { get; set; }
        public string move { get; set; }
        public string favSnack { get; set; }
        public double avgWeight { get; set; }
        public void Speak(string sound)
        {
            Console.WriteLine($"I go {sound}.");
        }
        public void Move(string move)
        {
            Console.WriteLine($"I {this.move} around the farm all day.");
        }
        public void Eat(string favSnack)
        {
            Console.WriteLine($"I like to eat {favSnack}.");
        }
        public void Weight(int avgWeight)
        {
            Console.WriteLine($"I usually weigh about {avgWeight}lbs.");
        }

    }
    //decide on four or more animals
    //for each animal decide on four or more methods
    public class Amphibian : Animal
    {
        string sound = "ribbit";
        string move = "hop";
        string favSnack = "flies";
        double avgWeight = .05d;

    }
    public class BullFrog : Amphibian
    {
        double avgWeight = .375d;

        internal void Move(object movement)
        {
            throw new NotImplementedException();
        }
    }

    public class Toad : Amphibian
    {
        double avgWeight = .175d;
    }



    class Program
    {
        static void Main(string[] args)
        {
            BullFrog kermit = new BullFrog();
            kermit.Move(kermit.move);
            kermit.Eat(kermit.favSnack);
        }
    }
}
