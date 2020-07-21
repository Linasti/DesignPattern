using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Adapter.Interfaces;
using DesignPattern.Adapter.Modules;

namespace DesignPattern.Adapter.Adapters
{
    public class MediaAdapter : MediaPlayer
    {
        private AdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if(audioType.ToLower() == "vlc")
                advancedMediaPlayer = new VlcPlayer();
            else if (audioType.ToLower() == "mp4")
                advancedMediaPlayer = new Mp4Player();
        }

        public string Play(string audioType, string fileName)
        {
            if(audioType.ToLower() == "vlc")
                return advancedMediaPlayer.PlayVlc(fileName);
            else if (audioType.ToLower() == "mp4")
                return advancedMediaPlayer.PlayMp4(fileName);
            return string.Empty;
        }
    }
}
