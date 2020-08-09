using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Template.Models
{
    public class Football : Game
    {
        protected override string Initialize()
        {
            return "Football Game Initialized! Start playing.";
        }

        protected override string StartPlay()
        {
            return "Football Game Started. Enjoy the game!";
        }

        protected override string EndPlay()
        {
            return "Football Game Finished!";
        }
    }
}
