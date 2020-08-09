using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Template
{
    public abstract class Game
    {
        protected abstract string Initialize();
        protected abstract string StartPlay();
        protected abstract string EndPlay();

        private const string SPACE = " ";
        //template method
        public string Play()
        {
            string result = string.Empty;
            //Initialize the game
            result += Initialize() + SPACE;

            //start game
            result += StartPlay() + SPACE;

            //end game
            result += EndPlay();

            return result;
        }
    }
}
