using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    internal class Player
    {
        //Attributes (Instance variables)
        private string name;
        private int score;
        private int livesLeft;

        public int healthLeft { get; set; }

        //Constructors (generates a new object)
        public Player(string name)
        {
            this.name = name;
        }//end method

        // Overload Constructor
        public Player(string name, int startingLives, int startingHealth)
        {
            this.name = name;
            livesLeft = startingLives;
            healthLeft = startingHealth;
        }// end method

        //Methods = behaviors or tasks that the object can perform
        public int GetScore()
        {
            return score;
        }//end method

        public void AddPoints(int totalPoints)
        {
            score += totalPoints;
        }// end method

        public void Kill()
        {
            //We make sure that they can't get negative lives
            if (livesLeft > 0)
            {
                livesLeft--;
            }
        }//end method

        public void EndHealth()
        {
            if (healthLeft > 0)
            {
                livesLeft -= 1;
                healthLeft--;
            }
        }

        public int GetLivesLeft()
        {
            return livesLeft;
        }//end method

    }// end class
} // end namespace
