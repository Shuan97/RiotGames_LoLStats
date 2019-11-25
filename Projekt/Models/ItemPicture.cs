using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Projekt
{
    class ItemPicture : PictureBox
    {
        private PictureBox picture = new PictureBox();

        public ItemPicture(int x)
        {
            picture.Size = new Size(30, 30);
            picture.Location = new Point(150+x*40, 5);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            //picture.Image = Image.FromFile("../../Resources/50x50.png");
            
        }


        public PictureBox GetPicture()
        {
            return picture;
        }
        public void SetPicture(int itemId)
        {
            picture.Image = DownloadImageFromUrl("http://stelar7.no/cdragon/latest/items/" + itemId + ".png");
        }

        public Image DownloadImageFromUrl(string imageUrl)
        {
            Image image = null;

            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                WebResponse webResponse = webRequest.GetResponse();

                Stream stream = webResponse.GetResponseStream();

                image = Image.FromStream(stream);

                webResponse.Close();
            }
            catch (Exception)
            {
                return null;
            }

            return image;
        }
    }
}
