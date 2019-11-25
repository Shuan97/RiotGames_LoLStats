using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    class ChampionPicture : PictureBox
    {
        private PictureBox picture = new PictureBox();

        public ChampionPicture()
        {
            picture.Size = new Size(40, 40);
            picture.Location = new Point(5, 5);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            //picture.Image = Image.FromFile("../../Resources/50x50.png");
        }


        public PictureBox GetPicture()
        {
            return picture;
        }
        public void SetPicture(int championId)
        {
            picture.Image = DownloadImageFromUrl("http://stelar7.no/cdragon/latest/champion-icons/" + championId + ".png");
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
