using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter.Interfaces
{
    public interface AdvancedMediaPlayer
    {
        public string PlayVlc(string fileName);
        public string PlayMp4(string fileName);
    }
}
