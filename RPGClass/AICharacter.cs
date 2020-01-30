using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClass
{
    public class AICharacter : Character
    {
        protected int AIattack;
        protected int AIdefend;
        private Random rand = new Random();
        public Character[] Group;

        public override string GetBattleChoice()
        {
            int num = rand.Next(1, ((AIattack) + 1));
            if (num > AIdefend)
            {
                return "A";
            }
            else
            {
                return "D";
            }
        }

    }
}
