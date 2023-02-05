using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi_4J_Library
{
    public class ComicProcessor
    {
        public async Task LoadComic(int numComic = 0)
        {
            string url = "";

            if (numComic > 0)
            {
                url = $"https://xkcd.com/{numComic}/info.0.json";
            }
            else
            {
                url = $"https://xkcd.com/info.0.json";
            }

            var response = await ApiHelper.ApiClient.GetAsync(url);
        }
    }
}
