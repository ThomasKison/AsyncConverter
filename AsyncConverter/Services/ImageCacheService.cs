using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AsyncConverter.Models;

namespace AsyncConverter.Services
{
    public class ImageCacheService
    {
        Random rnd = new Random();
        public ImageCacheService()
        {
        }

        public async Task<byte[]> GetImageData(Image image)
        {
            // we google for the image name on bing, and grab the first image
            // just to be more authentic ;-)
            using (var httpClient = new HttpClient())
            {
                var imgSearchHtml = await httpClient.GetStringAsync($"https://www.bing.com/images/search?q={image.Filename}");
                var matches = Regex.Matches(imgSearchHtml, "data-src=\"(.*?)\"");
                var index = rnd.Next(0, matches.Count - 1);
                var imgUrl = matches[index].Groups[1].Value;
                var res = await httpClient.GetByteArrayAsync(imgUrl);
                return res;
            }
        }
    }
}
