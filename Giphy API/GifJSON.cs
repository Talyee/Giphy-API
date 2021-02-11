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

        //yeah it's pretty hardcoded shh
        public original()
        {
            url = "error.png";
            width = "400";
            height = "300";
        }
    }
}
