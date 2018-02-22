using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayMp4(string Filename)
        {
            Console.WriteLine("Playing mp4 file: " + Filename);
        }

        public void PlayVlc(string Filename)
        {
            // Do nothing - Mp4Player Class
        }
    }
}
