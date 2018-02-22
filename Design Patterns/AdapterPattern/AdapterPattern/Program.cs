using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.Play("mp3", "Ride the Lightning.mp3");
            audioPlayer.Play("mp4", "Master of Puppets.mp4");
            audioPlayer.Play("vlc", "Jurassic World.vlc");
            audioPlayer.Play("avi", "Mind me.avi");

            Console.ReadLine();
        }
    }
}
