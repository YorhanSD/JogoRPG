using System;
using JogoRPG.src.Entities;
using JogoRPG.src.Functions;

namespace dotnet_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");

            ListCharacters lC = new ListCharacters();

            Hero falcaoNegro = new Hero("Falcão-Negro",780,"Voador");
            Hero punhoLaminado = new Hero("Punho-Laminado",950,"Variado");
            Hero ventoSelvagem = new Hero("Vento-Selvagem",650,"Atirador");
            Villain machadoDeGuerra = new Villain("Machado-de-Guerra",720,"Corpo-a-Corpo");
            Villain pilgrim = new Villain("Pilgrim",800,"Corpo-a-Corpo");
            Villain srCorrentes = new Villain("Sr. Correntes",640,"Magico");

            lC.listCharacters.Add(falcaoNegro);
            lC.listCharacters.Add(punhoLaminado);
            lC.listCharacters.Add(ventoSelvagem);
            lC.listCharacters.Add(machadoDeGuerra);

            lC.ListCreatedCharacters();

        }
    }
}
