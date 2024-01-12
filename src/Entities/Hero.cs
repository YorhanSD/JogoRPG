using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoRPG.src.Entities
{
    public class Hero: Character
    {
        public int moral;
        public Hero(string name, int health, string fightStyle):base(name, health, fightStyle)
        {

        }

        public override string SpecialMessage()
        {
            return $"Did you use the justice power!";
        }

        public override void SpecialAttack(int damage, Character villain)
        {
           damage += moral;
           villain.Health -= damage;

           Console.WriteLine($"You hit villain: {villain.Name} with special attack");
           Console.WriteLine($"You did: {damage} special attack damage to villain: {villain.Name}");
           UpdateHealth();
        }

        public override string UpdateHealth()
        {
            return $"Left: {Health} alive";
        }

        public override void Target(Character villain)
        {
            Console.WriteLine($"You chose the villain: {villain.Name} to fight");
        }

        public override void CalculateDamage(int damage, Character villain)
        {
            villain.Health -= damage;

            Console.WriteLine($"You did: {damage} damage to villain: {villain.Name}");
            Console.WriteLine($"{villain.Name} has {villain.Health} health now");
        }
    }
}