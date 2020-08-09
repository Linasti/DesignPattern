using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Template.Models
{
    public class Cricket : Game
    {
        protected override string Initialize()
        {
            return "Cricket Game Initialized! Start playing.";
        }

        protected override string StartPlay()
        {
            return "Cricket Game Started. Enjoy the game!";
        }

        protected override string EndPlay()
        {
            return "Cricket Game Finished!";
        }
    }
}
