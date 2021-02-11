using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giphy_API
{
    class GiphyObj
    {
        public GifJSON[] data { get; set; }
    }
    class GifJSON
    {
        public Image images { get; set; }
    }
    class Image
    {
        public original original { get; set; }
    }
    class original
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }

        public original()
        {
            url = "error.png";
            width = "300";
            height = "300";
        }
    }
}
