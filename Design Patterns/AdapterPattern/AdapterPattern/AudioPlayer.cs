using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class AudioPlayer : IMediaPlayer
    {

        MediaAdapter mediaAdapter;

        public void Play(string AudioType, string Filename)
        {
            // Indbygget mp3 understøttelse i AudioPlayer
            if (AudioType.Equals("mp3"))
            {
                Console.WriteLine("Playing mp3 file: " + Filename);
            }
            else if (AudioType.Equals("vlc") || AudioType.Equals("mp4"))
            {
                mediaAdapter = new MediaAdapter(AudioType);
                mediaAdapter.Play(AudioType, Filename);
            }
            else
            {
                Console.WriteLine("Invalid media. " + AudioType + " is not supported");
            }
        }
    }
}
