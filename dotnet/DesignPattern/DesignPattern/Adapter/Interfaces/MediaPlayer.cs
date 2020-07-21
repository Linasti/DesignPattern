using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter.Interfaces
{
    public interface MediaPlayer
    {
        public string Play(string audioType, string fileName);
    }
}
