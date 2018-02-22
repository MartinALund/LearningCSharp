using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class MediaAdapter : IMediaPlayer
    {

        IAdvancedMediaPlayer advancedMediaPlayer;


        public MediaAdapter(string AudioType)
        {
            if (AudioType.Equals("vlc"))
            {
                advancedMediaPlayer = new VlcPlayer();
            }
            else if (AudioType.Equals("mp4"))
            {
                advancedMediaPlayer = new Mp4Player();
            }
        }


        public void Play(string AudioType, string Filename)
        {
            if (AudioType.Equals("vlc"))
            {
                advancedMediaPlayer.PlayVlc(Filename);
            }
            else if (AudioType.Equals("mp4"))
            {
                advancedMediaPlayer.PlayMp4(Filename);
            }
        }


    }
}
