using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Chapter18Final
{
    class GetVideoInfo : Command
    {
        YoutubeClient receiver;

        public GetVideoInfo(YoutubeClient receiver)
        {
            this.receiver = receiver;
        }

        public override async Task Execute(string url)
        {
            var info = await receiver.Videos.GetAsync(url);

            Console.WriteLine(info.Title);
            Console.WriteLine(info.Description);

            Console.WriteLine();
        }
    }
}
