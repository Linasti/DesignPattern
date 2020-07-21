using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Adapter.Adapters;
using DesignPattern.Adapter.Interfaces;

namespace DesignPattern.Adapter
{
    public class AudioPlayer: MediaPlayer
    {

        public string Play(string audioType, string fileName)
        {
            if(audioType.ToLower() == "mp3")
                return $"Playing mp3 file. Name: {fileName}";
            
            if (audioType.ToLower() == "vlc" || 
                audioType.ToLower() == "mp4")
                return new MediaAdapter(audioType).Play(audioType, fileName);
            
            return $"Invalid media. {audioType} format not supported";

        }
    }
}
