using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JogoRPG.src.Entities;

namespace JogoRPG.src.Functions
{
    public class ListCharacters
    {
        public List<Character> listCharacters = new List<Character>();
        public void ListCreatedCharacters()
        {
            foreach(Character all in listCharacters)
            {
                Console.WriteLine($"Character name: {all.Name}");
            }
        }
    }
}