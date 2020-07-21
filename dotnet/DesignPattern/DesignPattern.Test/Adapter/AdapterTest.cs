using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Adapter;

namespace DesignPattern.Test.Adapter
{
    [TestFixture]
    public class AdapterTest
    {
        [TestCase("mp3", "beyond the horizon.mp3","Playing mp3 file. Name: beyond the horizon.mp3")]
        [TestCase("mp4", "alone.mp4","Playing mp4 file. Name: alone.mp4")]
        [TestCase("vlc", "far far away.vlc","Playing vlc file. Name: far far away.vlc")]
        [TestCase("avi", "mind me.avi","Invalid media. avi format not supported")]
        public void TestMethod(string audioType,string fileName, string expectedOutputPrint)
        {
            AudioPlayer audioPlayer = new AudioPlayer();

            string outputPrint = audioPlayer.Play(audioType,fileName );
            Assert.AreEqual(expectedOutputPrint,outputPrint);
        }
    }
}
