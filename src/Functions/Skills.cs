using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JogoRPG.src.Entities;

namespace JogoRPG.src.Functions
{
    public class Skills
    {
        string addSkill;
        int counter = 0;
        public void AddSkills()
        {
            do
            {
                Console.WriteLine("Describe this skill: ");
                addSkill = Console.ReadLine();
            }
            while(counter < 3);
        }
    }
}