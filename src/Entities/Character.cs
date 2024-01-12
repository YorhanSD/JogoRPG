using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoRPG.src.Entities
{
    public class Character
    {
        public List<string> characterSkills = new List<string>();
        public string Name;
        public int Health;
        public string FightStyle;

        public Character (string name, int health, string fightStyle)
        {
            Name = name;
            Health = health;
            FightStyle = fightStyle;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Health} {this.FightStyle}";
        }
        public virtual string SpecialMessage()
        {
            return $"Did you use the justice power!";
        }

        public virtual void SpecialAttack(int damage, Character character)
        {
           Console.WriteLine($"{character} activated special");
           character.Health -= damage;
           UpdateHealth();
        }

        public virtual string UpdateHealth()
        {
            return $"Left: {Health} alive";
        }

        public virtual void Target(Character character)
        {
            Console.WriteLine($"You chose the character: {character.Name} to fight");
        }

        public virtual void CalculateDamage(int damage, Character character)
        {
            character.Health -= damage;

            Console.WriteLine($"You did {damage} damage to character: {character.Name}");
            Console.WriteLine($"{character.Name} has {character.Health} health now");
        }
    }
}