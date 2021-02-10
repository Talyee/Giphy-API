using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;

namespace Giphy_API
{
    public partial class GifSearch : Form
    {
        public GifSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            querySearch();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
            {
                querySearch();
            }
        }

        private async void querySearch()
        {
            string gifUrl;

            try
            {
                string query = textBox1.Text;
                gifUrl = await searchGif(query);
            }
            catch
            {
                gifUrl = "error.png";
            }

            textBox1.Clear();
            //pictureBox1.Width = 
            pictureBox1.LoadAsync(gifUrl);
        }

        private static async Task<string> searchGif(string search)
        {
            original gif;

            Url url = "https://api.giphy.com/v1/gifs/search"
                .SetQueryParams(new
                {
                    api_key = "3ew4dVkATNGYPczraMdGSnuuMTjJXRgL",
                    q = search
                });
            GiphyObj giphyObj = await url.GetJsonAsync<GiphyObj>();
            if (giphyObj.data.Length > 0)
            {
                gif = giphyObj.data[0].images.original;
            }
            else
            {
                gif = "error.png";
            }
            return urlPicture;
        }
    }
    class GiphyObj
    {
        public Gif[] data { get; set; }
    }
    class Gif
    {
        public Image images { get; set; }
    }
    class Image
    {
        public original original { get; set; }
    }
    class original
    {
        public string url { get; set; } // = "error.png";
        public string width { get; set; }// = "200";
        public string height { get; set; }// = "200";
    }
}