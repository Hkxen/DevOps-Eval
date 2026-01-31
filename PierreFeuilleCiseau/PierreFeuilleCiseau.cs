using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PierreFeuilleCiseauProject
{
    public class PierreFeuilleCiseau
    {

        public string[] choices = { "Pierre", "Feuille", "Ciseau", "Lézard", "Spock" };
        public Random random = new Random();

        public string BotsPick()
        {
            int index = random.Next(0, choices.Length);
            return choices[index];
        }

        public string CheckIfPlayerWon(string playersChoice, string botsChoice)
        {
            if (playersChoice == botsChoice)
            {
                return "Egalité !";
            }
            if ((playersChoice == "Ciseau" && (botsChoice == "Feuille" || botsChoice == "Lézard")) ||
                (playersChoice == "Pierre" && (botsChoice == "Ciseau" || botsChoice == "Lézard")) ||
                (playersChoice == "Feuille" && (botsChoice == "Pierre" || botsChoice == "Spock")) ||
                (playersChoice == "Lézard" && (botsChoice == "Spock" || botsChoice == "Feuille")) ||
                (playersChoice == "Spock" && (botsChoice == "Ciseau" || botsChoice == "Pierre")))
            {
                return "Vous avez gagné !";
            }
            else
            {
                return "Vous avez perdu !";
            }
        }

        public bool IsTheChoiceValid(string playersChoice)
        {
            int pos = Array.IndexOf(choices, playersChoice);
            if (pos > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string PlayTheGame(string playersChoice, string botsChoice)
        {
            if (!IsTheChoiceValid(playersChoice))
            {
                throw new ArgumentException("Veuillez choisir entre pierre, feuille, ciseau, lézard et spock.");
            }

            var result = CheckIfPlayerWon(playersChoice, botsChoice);
            return $"{playersChoice} (vous) vs {botsChoice} (bot), {result}";
        }
    }
}
