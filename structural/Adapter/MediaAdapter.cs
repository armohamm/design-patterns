namespace Adapter
{
    class MediaAdapter : IMediaPlayer
    {
        IMediaMethods IMediaMethods;

        public MediaAdapter(string type)
        {
            if (type.Equals("avi"))
            {
                IMediaMethods = new AppleTV();
            }
            else if (type.Equals("mp3"))
            {
                IMediaMethods = new Ipod();
            }
        }
        public void play(string fileType, string fileName)
        {
            if(fileType.Equals("avi")){
                IMediaMethods.playVideo(fileName);
            }
            else if(fileType.Equals("mp3")){
                IMediaMethods.playMP3(fileName);
            }
        }
    }
}
