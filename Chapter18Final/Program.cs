using YoutubeExplode;

namespace Chapter18Final
{
    internal class Program
    {
        public static string GetFileNameFromUrl(string url)
        {
            return url.Substring(url.IndexOf('=')+1)+".mp4";
        }
        static async Task Main(string[] args)
        {
            if (args[0].Length< "https://www.youtube.com/watch?".Length)
            {
                Console.WriteLine("введите ссылку на видео youtube в качестве аргумента коммандной строки");
                return;
            }
            string url = args[0];
            //string url = "https://www.youtube.com/watch?v=AKJfakEsgy0";
            Sender sender = new Sender();
            YoutubeClient receiver = new YoutubeClient();

            Command command = new GetVideoInfo(receiver);

            sender.SetCommand(command);
            await sender.execute(url);

            command = new Download(receiver);
            sender.SetCommand(command);
            await sender.execute(url);  

        }
    }
}