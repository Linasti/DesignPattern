using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Adapter.Interfaces;

namespace DesignPattern.Adapter.Modules
{
    public class Mp4Player : AdvancedMediaPlayer
    {
        public string PlayVlc(string fileName)
        {
            return string.Empty;    
        }

        public string PlayMp4(string fileName)
        {
            return $"Playing mp4 file. Name: {fileName}";
        }
    }
}
