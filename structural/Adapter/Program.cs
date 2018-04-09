using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Player mediaPlayer = new Player();

            mediaPlayer.play("mp3", "Here comes the sun.mp3");
            mediaPlayer.play("avi", "House_of_Cards.avi");
            mediaPlayer.play("mp4", "Far away.mp4");
            mediaPlayer.play("WAV", "Come as you are.wav");
        }
    }
}
