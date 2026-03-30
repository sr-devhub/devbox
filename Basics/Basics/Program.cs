using Basics;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        var video = new Video() { Title = "Video 1" };
        var videoEncoder = new VideoEncoder();
        var mailservice = new MailService();
        var msgservice = new MessageService();
        videoEncoder.VideoEncoded += OnVideoEncoded;
        videoEncoder.VideoEncoded += mailservice.OnVideoEncoded;
        videoEncoder.VideoEncoded += msgservice.OnVideoEncoded;
        videoEncoder.Encode(video);

    }
    private static void OnVideoEncoded(object sender, VideoEventArgs args)
    {
        Console.WriteLine("Video has been encoded." +args.Video.Title);
    }

   

}
