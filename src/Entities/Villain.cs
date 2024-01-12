using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoRPG.src.Entities
{
    public class Villain: Character
    {
        public int victims;
        public Villain(string name, int health, string fightStyle):base(name, health, fightStyle)
        {

        }
        public override string SpecialMessage()
        {
            return $"Did you use the evil power!";
        }
        public override void SpecialAttack(int damage, Character heroi)
        {
           damage += victims;
           heroi.Health -= damage;

           Console.WriteLine($"You hit hero: {heroi.Name} with evil power!");
           Console.WriteLine($"You inflicted: {damage} evil power damage to hero: {heroi.Name}");
           UpdateHealth();
        }
        public virtual string UpdateHealth()
        {
            return $"Left: {Health} alive";
        }

        public override void Target(Character heroi)
        {
            Console.WriteLine($"You chose the hero: {heroi.Name} to kill!");
        }

        public override void CalculateDamage(int damage, Character heroi)
        {
            heroi.Health -= damage;

            Console.WriteLine($"You inflicted: {damage} damage to hero: {heroi.Name}");
            Console.WriteLine($"{heroi.Name} has {heroi.Health} health now");
        }
    }
}