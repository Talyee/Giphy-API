﻿using System;
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
            QuerySearch();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
            {
                QuerySearch();
            }
        }

        private async void QuerySearch()
        {
            original gifInfo;

            try
            {
                string query = textBox1.Text;
                gifInfo = await SearchGif(query);
            }
            catch 
            {
                gifInfo = new original();
            }
            int gifWidth = int.Parse(gifInfo.width);
            int gifHeight = int.Parse(gifInfo.height);

            textBox1.Clear();
            FormResize(gifWidth, gifHeight);
            pictureBox1.Load(gifInfo.url);
        }

        private void FormResize(int gifWidth, int gifHeight)
        {
            pictureBox1.Width = gifWidth;
            pictureBox1.Height = gifHeight;
            ActiveForm.Width = gifWidth + 100;
            ActiveForm.Height = gifHeight + 100;
            //textBox1.Location.X = ActiveForm
            //textBox1.AutoScrollOffset;
        }

        private static async Task<original> SearchGif(string search)
        {
            original gifInfo;

            Url url = "https://api.giphy.com/v1/gifs/search"
                .SetQueryParams(new
                {
                    api_key = "3ew4dVkATNGYPczraMdGSnuuMTjJXRgL",
                    q = search
                });
            GiphyObj giphyObj = await url.GetJsonAsync<GiphyObj>();
            if (giphyObj.data.Length > 0)
            {
                gifInfo = giphyObj.data[0].images.original;
            }
            else
            {
                gifInfo = new original();
            }
            return gifInfo;
        }
    }
}