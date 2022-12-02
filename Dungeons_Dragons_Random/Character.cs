using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_Dragons_Random
{
    internal class Character
    {

        string[] genders = { "Male", "Female" };
        string[] classes = { "Artificer", "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" };
        string[] races = { "Dragonborn", "Dwarf", "Elf", "Gnome", "Haf-Elf", "Halfling", "Half-Orc", "Human", "Tiefling" };

        public string Name { get; set; }
        public int age { get; set; }

        public string gender { get; set; }

        public string Class { get; set; }

        public string race { get; set; }

        Character(string name, int age, string gender, string Class, string race)
        {
            this.Name = name;
            this.age = age;
            this.gender = gender;
            this.Class = Class;
            this.race = race;
        }
        public Character(){}

        public Character randomCharacter()
        {

            Random random = new Random();

            string race  = races[random.Next(0, races.Length)];
            string Class = classes[random.Next(0, classes.Length)];
            int age = 0;

            if (race.Equals("Dragonborn"))
            {
                age = random.Next(1, 80);
            }
            if (race.Equals("Dwarf"))
            {
                age = random.Next(1, 350);
            }
            if (race.Equals("Elf"))
            {
                age = random.Next(1, 750);
            }
            if (race.Equals("Halfling"))
            {
                age = random.Next(1, 50);
            }
            if (race.Equals("Half-Elf"))
            {
                age = random.Next(1, 200);
            }
            if (race.Equals("Gnone"))
            {
                age = random.Next(1, 500);
            }
            if (race.Equals("Half-Orc"))
            {
                age = random.Next(1, 75);
            }
            if (race.Equals("Human"))
            {
                age = random.Next(1, 100);
            }
            if (race.Equals("Tiefling"))
            {
                age = random.Next(1, 120);
            }

            string gender = genders[random.Next(0, genders.Length)]; 

            return new Character("", age, gender, Class, race);
        }
    }
}
