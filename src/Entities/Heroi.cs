using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoRPG.src.Entities
{
    public class Heroi
    {
        public Vilan vilan;
        public int moral;
        public string Name;
        public int Level;
        public int Health;
        public string Type;

        public Heroi (string name, int level, int health, string type)
        {
            Name = name;
            Level = level;
            Health = health;
            Type = type;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Level} {this.Health} {this.Type}";
        }

        public virtual string Especial()
        {
            return $"Você usou o especial!";
        }
        public virtual void AtaqueEspecial(int damage, Vilan vilan)
        {
           vilan.Health -= damage;

           Console.WriteLine($"Você atingiu o vilão: {vilan.Name} com o ataque especial");
           Console.WriteLine($"Você causou: {damage + moral} de dano com o Ataque Especial ao Vilão: {vilan.Name}");
        }

        public virtual void Attack(Vilan vilan)
        {
            Console.WriteLine($"Você escolheu o vilão: {vilan.Name} para lutar");
        }
        public virtual void Damage(int damage, Vilan vilan)
        {
            vilan.Health -= damage;

            Console.WriteLine($"Você causou: {damage} de dano ao Vilão: {vilan.Name}");
            Console.WriteLine($"{vilan.Name} está com {vilan.Health} de vida agora");
        }
    }
}