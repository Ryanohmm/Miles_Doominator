using System;

namespace MilesVsDoom
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("🕷️ Miles Morales vs. Doctor Doom — Battle at the Bus Station 🚌\n");

            // Create class instances
            Hero miles = new Hero("Miles Morales", 100, "Venom Blast");
            Villain doom = new Villain("Doctor Doom", 120, "Electro Gauntlet");

            Console.WriteLine($"{miles.Name} arrives at the crowded bus station...");
            Console.WriteLine($"{doom.Name} emerges from the smoke, civilians screaming everywhere!\n");

            // Call methods on the class instances
            miles.Attack(doom);
            doom.Attack(miles);

            Console.WriteLine("\nMiles uses his special move!");
            miles.UseSpecial(doom);

            Console.WriteLine("\nDoom retaliates with a devastating blast!");
            doom.UseSpecial(miles);

            Console.WriteLine("\nFinal Status:");
            miles.DisplayStatus();
            doom.DisplayStatus();

            Console.WriteLine("\nThe battle rages on as buses screech away from the chaos...");
        }
    }

    // Base Character class
    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public string SpecialMove { get; set; }

        public Character(string name, int health, string specialMove)
        {
            Name = name;
            Health = health;
            SpecialMove = specialMove;
        }

        public virtual void Attack(Character target)
        {
            int damage = 10;
            target.Health -= damage;
            Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
        }

        public virtual void UseSpecial(Character target)
        {
            int damage = 25;
            target.Health -= damage;
            Console.WriteLine($"{Name} uses {SpecialMove} on {target.Name} for {damage} damage!");
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"{Name} — Health: {Health}");
        }
    }

    // Hero class
    class Hero : Character
    {
        public Hero(string name, int health, string specialMove)
            : base(name, health, specialMove) { }

        public override void Attack(Character target)
        {
            int damage = 12;
            target.Health -= damage;
            Console.WriteLine($"{Name} swings in with a web strike! {target.Name} takes {damage} damage.");
        }
    }

    // Villain class
    class Villain : Character
    {
        public Villain(string name, int health, string specialMove)
            : base(name, health, specialMove) { }

        public override void Attack(Character target)
        {
            int damage = 15;
            target.Health -= damage;
            Console.WriteLine($"{Name} unleashes a blast of dark tech! {target.Name} takes {damage} damage.");
        }
    }
}

