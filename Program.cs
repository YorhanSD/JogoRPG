using System;
using JogoRPG.src.Entities;

namespace dotnet_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo!");

            Heroi falcaoNegro = new Heroi("Falcão-Negro",78,780,"Voador");
            Heroi ventoSelvagem = new Heroi("Vento-Selvagem",65,650,"Atirador");
            Vilan machadoDeGuerra = new Vilan("Machado-de-Guerra",72,720,"Corpo-a-Corpo");

            Console.WriteLine(falcaoNegro);
            Console.WriteLine(ventoSelvagem);
            Console.WriteLine(machadoDeGuerra);

            falcaoNegro.moral = 48;
            machadoDeGuerra.numVitimas = 110;

            falcaoNegro.Attack(machadoDeGuerra);
            falcaoNegro.Damage(128,machadoDeGuerra);
            machadoDeGuerra.Attack(falcaoNegro);
            machadoDeGuerra.Damage(96,falcaoNegro);
            falcaoNegro.Especial();
            falcaoNegro.AtaqueEspecial(256,machadoDeGuerra);
            machadoDeGuerra.Especial();
            machadoDeGuerra.AtaqueEspecial(192,falcaoNegro);
        }
    }
}
