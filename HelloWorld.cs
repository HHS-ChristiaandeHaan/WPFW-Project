﻿// See https://aka.ms/new-console-template for more information 
//dotnet new console --use-program-main -lang "C#" -n "Week1Project" 
//zie dotnet new console -h voor informatie
//use-program-main om top level statements te verkomen.

using System.Text;
using Week1Project;

class HelloWorld
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!\n");
        //BoterKaasEieren boterKaasEieren = new BoterKaasEieren();
        //boterKaasEieren.Speler();
        //boterKaasEieren.PrintVeld();
        //boterKaasEieren.Spel();
        Kaart k = new Kaart(30, 30);
        Pad p1 = new Pad();
        p1.van = new Coordinaat(2, 5);
        p1.van = new Coordinaat(12, 30);
        k.VoegPadToe(p1);
        Pad p2 = new Pad
        {
            van = new Coordinaat(26, 4),
            naar = new Coordinaat(10, 5)
        };
        k.VoegPadToe(p2);
        k.VoegItemToe(new Attractie(k, new Coordinaat(15, 15)));
        k.VoegItemToe(new Attractie(k, new Coordinaat(20, 15)));
        k.VoegItemToe(new Attractie(k, new Coordinaat(5, 18)));
        k.Teken(new ConsoleTekener());
        new ConsoleTekener().SchrijfOp(new Coordinaat(0, k.Hoogte + 1), "Deze kaart is schaal 1:1000");
        System.Console.Read();
    }
}