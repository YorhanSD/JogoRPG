using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JogoRPG.src.Entities;

namespace JogoRPG.src.Functions
{
    public class CreateCharacter
    {
        private int exit;
        private int choice;
        public void AddCharacter()
        {
            do
            {
                Console.WriteLine("Select an option: ");
                Console.WriteLine("Create a hero press 1");
                Console.WriteLine("Create a villain press 2");
                Console.WriteLine("Exit 3");

                switch(choice)
                {
                    case 1:
                    CreateHero();
                    break;

                    case 2:
                    CreateVillain();
                    break;
                }

            }while(exit != 3);

        }

        public void CreateHero()
        {
            Hero hero = new Hero("",0,"");

            Console.WriteLine("What´s your hero´s name? ");

            hero.Name = Console.ReadLine();
        }

        public void CreateVillain()
        {
            Villain villain = new Villain("",0,"");

            Console.WriteLine("What´s your villain´s name? ");

            villain.Name = Console.ReadLine();
        }
    }
}