using System;

namespace CSharp_Exercise04_Casses_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rabbits

            Rabbit bugsbunny = new Rabbit("Bugs Bunny");
            bugsbunny.Sound = "(rabbit noise)";
            bugsbunny.Food = "Grass";
            Rabbit.HowSpeaks(bugsbunny);
            Rabbit.WhatEats(bugsbunny);
            Rabbit rogerrabbit = new Rabbit("Roger Rabbit");
            rogerrabbit.Sound = "(rabbit silence)";
            rogerrabbit.Food = "Still Grass";
            Rabbit.HowSpeaks(rogerrabbit);
            Rabbit.WhatEats(rogerrabbit);
            Rabbit thumper = new Rabbit("Thumper");
            thumper.Sound = "(rabbit sound)";
            thumper.Food = "Still More Grass";
            Rabbit.HowSpeaks(thumper);
            Rabbit.WhatEats(thumper);
            Rabbit petercotontail = new Rabbit("Peter Cotontail");
            petercotontail.Sound = "kackaaaaa";
            petercotontail.Food = "Letuce";
            Rabbit.HowSpeaks(petercotontail);
            Rabbit.WhatEats(petercotontail);
            
            //Horses

            Horse ed = new Horse();
            ed.Name = "Mr. Ed";
            ed.Sound = "neigh";
            Horse.Introduce(ed);
            Horse jeff = new Horse();
            jeff.Name = "Jeff";
            jeff.Sound = "neigh";
            Horse.Introduce(jeff);
            Horse steve = new Horse();
            steve.Name = "Steve";
            steve.Sound = "neigh";
            Horse.Introduce(steve);
            Horse james = new Horse();
            james.Name = "James";
            james.Sound = "neigh";
            Horse.Introduce(james);

            //Pigs

            Pig stinky = new Pig();
            stinky.Name = "Stinky";
            stinky.Sound = "Oink";
            Pig.Introduce(stinky);
            Pig smelly = new Pig();
            smelly.Name = "Smelly";
            smelly.Sound = "Oink";
            Pig.Introduce(smelly);
            Pig dirty = new Pig();
            dirty.Name = "Dirty";
            dirty.Sound = "Oink";
            Pig.Introduce(dirty);
            Pig mudy = new Pig();
            mudy.Name = "Mudy";
            mudy.Sound = "Oink";
            Pig.Introduce(mudy);

            //Chickens

            Chicken stan = new Chicken();
            stan.Name = "Stan";
            stan.Sound = "kikiriki";
            Chicken.Introduce(stan);
            Chicken kenny = new Chicken();
            kenny.Name = "Kenny";
            kenny.Sound = "kikiriki";
            Chicken.Introduce(kenny);
            Chicken cartman = new Chicken();
            cartman.Name = "Cartman";
            cartman.Sound = "kikiriki";
            Chicken.Introduce(cartman);
            Chicken kyle = new Chicken();
            kyle.Name = "Kyle";
            kyle.Sound = "kikiriki";
            Chicken.Introduce(kyle);
        }
    }
    class Rabbit
    {
        public string Name;
        public string Sound;
        public string Food;
        public Rabbit()
        {
            Name = "No name given";
        }
        public Rabbit(string name)
        {
            Name = name;
        }
        public static void HowSpeaks(Rabbit animal)
        {
            Console.WriteLine($"{animal.Name} goes {animal.Sound}");
        }
        public static void WhatEats(Rabbit animal)
        {
            Console.WriteLine($"{animal.Name} eats {animal.Food}");
        }
    }
    class Horse
    {
        public string Name;
        public string Sound;
        public static void Introduce(Horse animal)
        {
            Console.WriteLine($"My name is {animal.Name} and I am a horse. I say {animal.Sound}");
        }
    }
    class Pig
    {
        public string Name;
        public string Sound;
        public static void Introduce(Pig animal)
        {
            Console.WriteLine($"My name is {animal.Name} and I am a pig. I say {animal.Sound}");
        }
    }
    class Chicken
    {
        public string Name;
        public string Sound;
        public static void Introduce(Chicken animal)
        {
            Console.WriteLine($"My name is {animal.Name} and I am a chicken. I say {animal.Sound}");
        }
    }
}
