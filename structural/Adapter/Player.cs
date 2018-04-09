using Adapter;
using System;

public class Player : IMediaPlayer

{
    MediaAdapter mediaAdapter;
    public void play(string fileType, string fileName)
    {
        if(fileType.Equals("mp3")){
            Console.WriteLine("Playing mp3 file. " + fileName);
        }
        else if(fileType.Equals("avi") || fileType.Equals("mp4")){
            mediaAdapter = new MediaAdapter(fileType);
            mediaAdapter.play(fileType, fileName);
        }
        else{
            Console.WriteLine("Invalid media type. " + fileType + " format is not supported.");
        }
    }
}