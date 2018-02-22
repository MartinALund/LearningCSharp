using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4(string Filename)
        {
            //Do nothing - VlcPlayer Class
        }

        public void PlayVlc(string Filename)
        {
            Console.WriteLine("Playing vlc file: " + Filename);
        }
    }
}
