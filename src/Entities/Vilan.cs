using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoRPG.src.Entities
{
    public class Vilan: Heroi
    {
        public int numVitimas;
        public Vilan(string name, int level, int health, string type):base(name,level,health,type)
        {

        }
        public override string Especial()
        {
            return $"Você usou o poder maligno!";
        }
        public virtual void AtaqueEspecial(int damage, Heroi heroi)
        {
           heroi.Health -= damage;

           Console.WriteLine($"Você atingiu o heroi: {heroi.Name} com o poder maligno");
           Console.WriteLine($"Você infligiu: {damage + numVitimas} de dano com o Poder Maligno ao Heroi: {heroi.Name}");
        }
        public void Attack(Heroi heroi)
        {
            Console.WriteLine($"Você escolheu o heroi: {heroi.Name} para matar");
        }

        public void Damage(int damage, Heroi heroi)
        {
            heroi.Health -= damage;

            Console.WriteLine($"Você infligiu: {damage} de dano ao Heroi: {heroi.Name}");
            Console.WriteLine($"{heroi.Name} está com {heroi.Health} de vida agora");
        }
    }
}