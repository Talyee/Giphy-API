using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;

namespace Giphy_API
{
    public partial class GifSearchForm : Form
    {
        public string loadingText = "Loading...";
        public string errorText = "Could not locate a gif :(";

        public GifSearchForm()
        {
            InitializeComponent();
        }

        //search button query input
        private void button1_Click(object sender, EventArgs e)
        {
            QuerySearch();
        }

        //enter query input
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
            {
                QuerySearch();
                e.SuppressKeyPress = true; //stops the windows ding
            }
        }

        //framework for getting gif info and displaying it
        private async void QuerySearch()
        {
            DisplayGifBox.Hide();
            TextLabel.Show();

            string query = InputTextBox.Text;
            Task<original> gifInfoTask = SearchGif(query);
            TextLabel.Text = loadingText;
            InputTextBox.Clear();
            original gifInfo = await gifInfoTask;
            int gifWidth = int.Parse(gifInfo.width);
            int gifHeight = int.Parse(gifInfo.height);
            FormResize(gifWidth, gifHeight);
            DisplayGifBox.LoadAsync(gifInfo.url);

            TextLabel.Hide();
            DisplayGifBox.Show();
        }

        //resizes form based on new gif
        private void FormResize(int gifWidth, int gifHeight)
        {
            DisplayGifBox.Width = gifWidth;
            DisplayGifBox.Height = gifHeight;
            TextLabel.Width = gifWidth;
            TextLabel.Height = gifHeight;
            ActiveForm.Width = gifWidth + 100;
            ActiveForm.Height = gifHeight + 200;
        }

        //the API stuff
        private async Task<original> SearchGif(string search)
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
                TextLabel.Text = errorText;
            }
            return gifInfo;
        }
    }
}