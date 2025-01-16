using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterChifoumi
{
    public class Chifoumi
    {
        public Moove Moove { get; set; }

        public Chifoumi() { }

        //public static Moove GetPlayerMove()
        //{
        //    Console.WriteLine("Choisissez votre mouvement :");
        //    Console.WriteLine("1 - Pierre");
        //    Console.WriteLine("2 - Papier");
        //    Console.WriteLine("3 - Ciseaux");
        //    Console.WriteLine("4 - Lézard");
        //    Console.WriteLine("5 - Spock");
        //    Console.WriteLine("L'entrée doit être un de ces 5 chiffres :");

        //    string? input = Console.ReadLine();
        //    int playerChoice;

        //    while (!int.TryParse(input, out playerChoice) || playerChoice < 1 || playerChoice > 5)
        //    {
        //        Console.WriteLine("L'entrée est incorrecte, elle doit être un de ces 5 chiffres (1, 2, 3, 4, 5) :");
        //        input = Console.ReadLine();
        //    }

        //    return (Moove)playerChoice;
        //}

        public static Moove GetPlayerMove(int input)
        {
            Console.WriteLine("Choisissez votre mouvement :");
            Console.WriteLine("1 - Pierre");
            Console.WriteLine("2 - Papier");
            Console.WriteLine("3 - Ciseaux");
            Console.WriteLine("4 - Lézard");
            Console.WriteLine("5 - Spock");
            Console.WriteLine("L'entrée doit être un de ces 5 chiffres :");

            while (input < 1 || input > 5)
            {
                Console.WriteLine("L'entrée est incorrecte, elle doit être un de ces 5 chiffres (1, 2, 3, 4, 5) :");
            }

            return (Moove)input;
        }

        public static Moove GetAIMove()
        {
            Random rand = new Random();
            int aiChoice = rand.Next(1, 6);
            return (Moove)aiChoice;
        }

        public static string Winner(Moove playerMove, Moove aiMove)
        {
            if (playerMove == aiMove)
            {
                return "Égalité !";
            }

            switch (playerMove)
            {
                case Moove.rock:
                    if (aiMove == Moove.scissors || aiMove == Moove.lizard)
                        return "Vous gagnez !";
                    else
                        return "L'IA gagne !";
                case Moove.paper:
                    if (aiMove == Moove.rock || aiMove == Moove.spock)
                        return "Vous gagnez !";
                    else
                        return "L'IA gagne !";
                case Moove.scissors:
                    if (aiMove == Moove.paper || aiMove == Moove.lizard)
                        return "Vous gagnez !";
                    else
                        return "L'IA gagne !";
                case Moove.lizard:
                    if (aiMove == Moove.paper || aiMove == Moove.spock)
                        return "Vous gagnez !";
                    else
                        return "L'IA gagne !";
                case Moove.spock:
                    if (aiMove == Moove.rock || aiMove == Moove.scissors)
                        return "Vous gagnez !";
                    else
                        return "L'IA gagne !";
                default:
                    return "Erreur";
            }
        }

        public static void Main(int playerMoove)
        {
            Moove playerMove = GetPlayerMove(playerMoove);
            Moove aiMove = GetAIMove();

            Console.WriteLine($"Votre choix : {playerMove}");
            Console.WriteLine($"Choix de l'IA : {aiMove}");

            string result = Winner(playerMove, aiMove);
            Console.WriteLine(result);
        }
    }
}
