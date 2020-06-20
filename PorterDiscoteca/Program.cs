using System;
using System.Collections.Generic;
using PorterDiscoteca.Model;

namespace PorterDiscoteca
{
    class Program
    {
        static void Main(string[] args)
        {
            var cua = new List<Persona> {
                new Persona("Pere Pi", Sexe.Home, 120, 200, Calçat.Vambes, false, true),
                new Persona("Filomeno Garcia", Sexe.Home, 45, 123, Calçat.SabatesDeMudar, false, true),
                new Persona("Maria Fernandez", Sexe.Dona, 30, 120, Calçat.Sandalies, false, true),
                new Persona("Frederico Puig", Sexe.Home, 43, 500, Calçat.Vambes, false, false),
                new Persona("Joni Soler", Sexe.Home, 12, 30, Calçat.Sandalies, true, true),
                new Persona("Emilia Magí", Sexe.Dona, 80, 240, Calçat.SabatesDeMudar, false, true),
                new Persona("Esther González", Sexe.Dona, 70, 120, Calçat.Xancletes, false, false),
                new Persona("Nicolau Bonilla", Sexe.Home, 40, 100, Calçat.SabatesDeMudar, false, false),
                new Persona("Irene Rosa", Sexe.Dona, 50, 75, Calçat.SabatesDeMudar, false, false),
                new Persona("Eugeni Perez", Sexe.Home, 90, 310, Calçat.Sandalies, false, true),
                new Persona("Bernat Ventura", Sexe.Home, 48, 530, Calçat.SabatesDeMudar, false, false),
                new Persona("Melania Osuna", Sexe.Dona, 84, 90, Calçat.Sandalies, false, true),
                new Persona("Maria Nevado", Sexe.Dona, 61, 160, Calçat.SabatesDeMudar, false, false),
                new Persona("Victoria Espasa", Sexe.Dona, 35, 150, Calçat.Xancletes, false, false),
                new Persona("Andreu Valls", Sexe.Home, 550, 230, Calçat.SabatesDeMudar, false, false),
                new Persona("Isabel Pi", Sexe.Dona, 42, 300, Calçat.Xancletes, false, true),
                new Persona("Juan Carlos Matos", Sexe.Home, 215, 350, Calçat.Vambes, true, true),
                new Persona("Myriam Zhou", Sexe.Dona, 38, 190, Calçat.Sandalies, false, false),
                new Persona("Julian Català", Sexe.Home, 12, 100, Calçat.Vambes, false, false)
            };

            foreach (var persona in cua)
            {
                Console.WriteLine($"{persona.Nom} no entra");
            }

        }
    }
}
