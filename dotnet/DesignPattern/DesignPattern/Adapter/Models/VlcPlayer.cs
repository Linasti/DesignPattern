using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Adapter.Interfaces;

namespace DesignPattern.Adapter.Modules
{
    public class VlcPlayer : AdvancedMediaPlayer
    {
        public string PlayVlc(string fileName)
        {
            return $"Playing vlc file. Name: {fileName}";
        }

        public string PlayMp4(string fileName)
        {
            return string.Empty;
        }
    }
}
