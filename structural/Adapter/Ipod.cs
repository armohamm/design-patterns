using System;

namespace Adapter
{
    class Ipod : IMediaMethods
    {
        public void playMP3(string fileName)
        {
            Console.WriteLine("Playing .mp3 file: " + fileName);
        }

        public void playVideo(string fileName)
        {
            Console.WriteLine("Ipod doesn't support videos.");
        }
    }
}
