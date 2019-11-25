using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Projekt
{
    class GameContent : Panel
    {
        private Panel panel = new Panel();
        private Panel borderPanel = new Panel();
        private Label result = new Label();
        private Label score = new Label();
        private List<ItemPicture> images = new List<ItemPicture>();
        private ChampionPicture champion = new ChampionPicture();

        public GameContent(int y)
        {

            panel.Location = new Point(0, y);
            panel.Size = new Size(500, 50);
            borderPanel.BackColor = Color.Gray;
            borderPanel.Location = new Point(0, 48);
            borderPanel.Size = new Size(500, 2);
            result.Size = new Size(100, 20);
            result.Location = new Point(60, 5);
            score.Size = new Size(100, 20);
            score.Location = new Point(60, 25);
            for (int i = 0; i < 6; i++)
            {
                images.Add(new ItemPicture(i));                                             
            }
            
            if (y % 100 == 0)
            {
                panel.BackColor = Color.White;
            }
            else
            {
                panel.BackColor = Color.LightGray;
            }       

            for (int i = 0; i < 6; i++)
            {
                panel.Controls.Add(images[i].GetPicture());
            }
            panel.Controls.Add(champion.GetPicture());
            panel.Controls.Add(result);
            panel.Controls.Add(score);
            panel.Controls.Add(borderPanel);
        }

        public Panel GetPanel()
        {
            return panel;
        }
         public void SetPanel(int item1, int item2, int item3, int item4, int item5, int item6, int championId, string result, string score)
        {
            images[0].SetPicture(item1);
            images[1].SetPicture(item2);
            images[2].SetPicture(item3);
            images[3].SetPicture(item4);
            images[4].SetPicture(item5);
            images[5].SetPicture(item6);
            champion.SetPicture(championId);
            this.result.Text = result;
            this.score.Text = "KDA: " + score;
        }

        
    }
}
