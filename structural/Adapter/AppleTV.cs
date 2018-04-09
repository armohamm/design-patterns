using System;

namespace Adapter
{
    class AppleTV : IMediaMethods
    {
        public void playMP3(string fileName)
        {
            Console.WriteLine("Apple TV doesn't support MP3.");
        }

        public void playVideo(string fileName)
        {
            Console.WriteLine("Playing video file: " + fileName);
        }
    }
}
