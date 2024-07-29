using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice
{
    public class DiceHelper
    {
        public static void UserRollsDice()
        {
            Console.WriteLine(
                "DICE ROLL UTILITY\n" +
                "====================\n\n" +
                "Please select dice to roll\n" +
                "1: 4 Sided Dice\n" +
                "2: 6 Sided Dice\n" +
                "3: 8 Sided Dice\n" +
                "4: 10 Sided Dice\n" +
                "5: 12 Sided Dice\n" +
                "6: 20 Sided Dice\n" +
                "7: 100 Sided Dice\n");
            Console.Write("Selection: ");
            string ?userInput = Console.ReadLine();

            Dice newDice = DiceRoller(userInput);
            
            PrintDiceResultSheet(newDice);
        }
        public static void PrintDiceResultSheet(Dice newDice)
        {
            string end = "";
            while (end != "end")
            {
                Console.Clear();
                Console.WriteLine(
                   "DICE ROLL UTILITY\n" +
                   "====================\n\n" +
                   "Result of roll.\n" +
                   $"You rolled {newDice.NumberOfDice} {newDice.Name}.\n" +
                   $"the Sum of your dice was: {newDice.SumRolledNumber}\n\n");
                Console.Write("Numbers Rolled: ");
                foreach (int item in newDice.NumbersRolled)
                {
                    Console.Write($"|\t{item}\t|");
                }
                Console.Write("\nPress Enter to roll again");
                end = Console.ReadLine();
            }
        }
        public static Dice DiceRoller(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    D4 d4 = new D4(numberOfDiceRolled());
                    return d4;
                case "2":
                    D6 d6 = new D6(numberOfDiceRolled());
                    return d6;
                case "3":
                    D8 d8 = new D8(numberOfDiceRolled());
                    return d8;
                case "4":
                    D10 d10 = new D10(numberOfDiceRolled());
                    return d10;
                case "5":
                    D12 d12 = new D12(numberOfDiceRolled());
                    return d12;
                case "6":
                    D20 d20 = new D20(numberOfDiceRolled());
                    return d20;
                case "7":
                    D100 d100 = new D100(numberOfDiceRolled());
                    return d100;
                default:
                    return null;
            }
        }
        public static int numberOfDiceRolled()
        {
            Console.Clear();
            Console.WriteLine(
                "DICE ROLL UTILITY\n" +
                "====================\n\n");
            Console.Write("Please enter number of dice you want to roll: ");
            int numberOfDice = int.Parse(Console.ReadLine());
            return numberOfDice;
        }
        public static int RandomNumberGenerator(int diceType)
        {
            Random diceRoll = new Random();
            int numberGenerated = diceRoll.Next(1, 5);

            return numberGenerated;
        }
        public static List<int> RollDice(int diceType, int numberOfDiceRolled)
        {
            List<int> ListOfRolledDice = new List<int>();

            for (int i = 0; i < numberOfDiceRolled - 1; i++)
            {
                ListOfRolledDice.Add(RandomNumberGenerator(diceType));
            }

            return ListOfRolledDice;
        }
    }
}
