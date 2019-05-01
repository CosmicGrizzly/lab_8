using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        private static string[] starwarsCharacters = { "Darth Vader", "Yoda", "Luke Skywalker", "Princess Leia", "Jabba the Hutt", "Obi-Wan Kenobi", "Boba Fett", "Han Solo", "Emperor Palpatine", "Darth Maul", "Jar Jar Binks", "R2-D2", "C-3PO", "Lando Calrissian", "Qui-Gon Jinn", "Mace Windu", "Jango Fett", "Admiral Ackbar", "Greedo", "Chewbacca" };
        private static string[] planetofbirth = { "Tatooine", " no one knows", "Polis Massa", "Polis Massa", "Nal Hutta", "Stewjon", "Kamino", "Corellia", "Naboo", "Iridonia", "Naboo", "data unknown: Memory Wiped", "Created on Tatooine", "Socorro", "Coruscant", "Haruun Kal", "Concord", "Mon Cala", "Rodia", "Kashyyyk" };
        private static string[] weapon = { "Force Choke!", "Confusing backwards statements", "Peace talks", "Sassy-ness", "a Rancor pit", "Wisdom", "a Flamethrower", "a lot of Blaster with a hint of sarcasm", "Force Lightning", "a Double Bladed Death", "Dumb Luck", "Snarky Beeps and Boops", "Proper Syntax", "Sabacc cards", "Summoning the combined power of Zeus,Ra's Al Ghul and a jedi together", "Getting in every movie in hollywood", "a Jet Pack and Blaster", "Figuring out when its a trap!", "Apparently shooting first", "Pulling roughly on chess players arms" };



        static void Main(string[] args)
        {
            string[] userInput;

            Console.Write("Welcome to the galaxy give me a number between 1-20 to find out who lives here: ");
            userInput = AskNumChar();

            Console.Write(string.Format("The character you selected is {0}",userInput[0] ));

            Console.Write(string.Format(" who was born on the {0}",userInput[1]));

            Console.WriteLine(" and their weapon of choice is {0}",userInput[2]);

            Console.Write("Would you like to choose a new character? (Yes/No) ");
            string response = Console.ReadLine().ToLower();

            if (response == "yes")
            {
                Main(args);
            }
        }

        private static string[] AskNumChar()
        {
            int userInput;
            try
            {
                userInput = int.Parse(Console.ReadLine()) - 1;
            }
            catch (FormatException ex)
            {
                Console.Write("You've entered an incorrect character please try again! ");
                return AskNumChar();
            }
            string chosenStarWarsCharacter;
            string homeWorld;
            string weaponofchoice;
            try
            {

                chosenStarWarsCharacter = starwarsCharacters[userInput];
                homeWorld = planetofbirth[userInput];
                weaponofchoice = weapon[userInput];


            }
            catch (IndexOutOfRangeException)
            {
                Console.Write("That character does not exist. Please try again (enter a number between 1-20: ");
                return AskNumChar();
            }
            string[] result = { chosenStarWarsCharacter, homeWorld, weaponofchoice };
            return result;
        }
    }
}
