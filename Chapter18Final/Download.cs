using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Chapter18Final
{
    internal class Download : Command
    {
        YoutubeClient receiver;

        public Download(YoutubeClient receiver)
        {
            this.receiver = receiver;
        }

        public override async Task Execute(string url)
        {
            await receiver.Videos.DownloadAsync(url, Program.GetFileNameFromUrl(url), builder => builder.SetPreset(ConversionPreset.UltraFast));
        }
    }
}
        