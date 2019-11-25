using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt

{
    public partial class Form : System.Windows.Forms.Form
    {
        public static string nickname;
        public bool isHide;

        private List<GameContent> content = new List<GameContent>();

        public Form()
        {
            InitializeComponent();
            isHide = true;
            Panel.AutoScroll = false;
            Panel.HorizontalScroll.Enabled = false;
            Panel.HorizontalScroll.Maximum = 0;
            Panel.AutoScroll = true;
            InitializePanel();
        }


        public async void SearchButton_Click(object sender, EventArgs e)
        {
            nickname = SearchText.Text;

            Task<Summoner> taskGetSummoner = new Task<Summoner>(() => WebServiceHandler.GetSummoner(StringNameToURLCode()));
            taskGetSummoner.Start();
            ResultLabel.Text = "Oczekiwanie...";
            Summoner summoner = await taskGetSummoner;

            if (summoner == null)
            {
                ResultLabel.Text = "Nie znaleziono przywoływacza";
                return;
            }
            ResultLabel.Text = nickname;
            LevelLabel.Text = "Poziom: " + summoner.SummonerLevel;

            Task<Tuple<LeagueTT, LeagueFlex, LeagueSolo>> taskGetLeague = new Task<Tuple<LeagueTT, LeagueFlex, LeagueSolo>>(() => WebServiceHandler.GetLeague(summoner.Id));
            taskGetLeague.Start();

            Tuple<LeagueTT, LeagueFlex, LeagueSolo> tuple = await taskGetLeague;
            string iconId = summoner.ProfileIconId;
            Image image = DownloadImageFromUrl("http://ddragon.leagueoflegends.com/cdn/8.24.1/img/profileicon/" + iconId + ".png");
            IconBox.Image = image;
            try
            {
                TTImage.Image = SetImage(tuple.Item1.Tier);
                TTLabel.Text = tuple.Item1.Tier + " " + tuple.Item1.Rank;
            }
            catch (Exception)
            {
                TTImage.Image = SetImage("unranked");
                TTLabel.Text = "UNRANKED";
            }
            try
            {
                FlexImage.Image = SetImage(tuple.Item2.Tier);
                FlexLabel.Text = tuple.Item2.Tier + " " + tuple.Item2.Rank;
            }
            catch (Exception)
            {
                FlexImage.Image = SetImage("unranked");
                FlexLabel.Text = "UNRANKED";
            }
            try
            {
                SoloImage.Image = SetImage(tuple.Item3.Tier);
                SoloLabel.Text = tuple.Item3.Tier + " " + tuple.Item3.Rank;
            }
            catch (Exception)
            {
                SoloImage.Image = SetImage("unranked");
                SoloLabel.Text = "UNRANKED";
            }

            Task<List<GameIds>> taskGetList = new Task<List<GameIds>>(() => WebServiceHandler.GetMatchesId(summoner.AccountId.ToString()));
            taskGetList.Start();

            List<GameIds> list = await taskGetList;

            for (int i = 0; i < 20; i++)
            {
                Task<Match> taskGetMatch = new Task<Match>(() => WebServiceHandler.GetMatch(list[i].GameId));
                taskGetMatch.Start();

                Match match = await taskGetMatch;
                for (int j = 0; j < 10; j++)
                {
                    if (summoner.AccountId == match.participantIdentities[j].player.accountId)
                    {
                        string score = match.participants[j].stats.kills.ToString() + " / " + match.participants[j].stats.deaths.ToString() + " / " 
                                       + match.participants[j].stats.assists.ToString();

                        content[i].SetPanel(match.participants[j].stats.item0, match.participants[j].stats.item1, match.participants[j].stats.item2,
                            match.participants[j].stats.item3, match.participants[j].stats.item4, match.participants[j].stats.item5,
                            match.participants[j].championId, GetResult(summoner, match, i), score);
                    }
                }
            }           
            PanelTimer.Start();           
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

        /// <summary>
        /// Metoda konwertująca znaki UTF-8 na zapis hex w celu poprawnej składni URL
        /// </summary>

        public static string StringNameToURLCode()
        {
            string myName = nickname;
            List<char> chars = new List<char> { ' ', 'á', 'ę', 'ś' };
            char[] charArray = myName.ToCharArray(0, myName.Length);
            StringBuilder newName = new StringBuilder();
            StringBuilder tempName = new StringBuilder();
            newName.Append(myName);

            foreach (Char sign in chars)
            {

                for (int i = 0; i < newName.ToString().Length; i++)
                {

                    if (charArray[i] == sign)
                    {

                        byte[] b = new byte[0];
                        b = Encoding.UTF8.GetBytes(sign.ToString());


                        StringBuilder sb = new StringBuilder();
                        foreach (byte d in b)
                        {
                            sb.Append("%");
                            sb.Append(string.Format("{0:X2}", d));
                        }
                        tempName.Append(sb);
                    }
                    else
                    {
                        tempName.Append(charArray[i]);
                    }
                }
                charArray = tempName.ToString().ToCharArray();
                newName = tempName;
                tempName = new StringBuilder();
            }
            return newName.ToString();
        }

        public Image SetImage(string name)
        {
            if (name == "GRANDMASTER")
            {
                name = "challenger";
            }
            Image image = Image.FromFile("../../Resources/Divisions/tier_" + name.ToLowerInvariant() + ".png");

            return image;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (isHide)
            {
                Panel.Location = new Point(Panel.Location.X - 5, Panel.Location.Y);
                if (Panel.Location.X <= 500)
                {
                    PanelButton.Text = ">";
                    PanelTimer.Stop();
                    isHide = false;
                    this.Refresh();
                }
            }
        }

        public void InitializePanel()
        {
            for (int i = 0; i < 20; i++)
            {
                content.Add(new GameContent(i*50));
                Panel.Controls.Add(content[i].GetPanel()); 
            }
        }


        private string GetResult(Summoner summoner, Match match, int j)
        {
            string matchResult = null;

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    if (summoner.AccountId == match.participantIdentities[i].player.accountId)
                    {
                        if (match.participants[i].teamId == 200 && match.teams[1].win == "Win")
                        {
                            matchResult = "Wygrana";
                        }
                        else if (match.participants[i].teamId == 200 && match.teams[1].win == "Fail")
                        {
                            matchResult = "Porażka";
                        }
                        else if (match.participants[i].teamId == 100 && match.teams[1].win == "Win")
                        {
                            matchResult = "Wygrana";
                        }
                        else if (match.participants[i].teamId == 100 && match.teams[1].win == "Fail")
                        {
                            matchResult = "Porażka";
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    //throw;
                }
            }
            return matchResult;
        }

        private void PanelTimer2_Tick(object sender, EventArgs e)
        {
            if (isHide)
            {
                Panel.Location = new Point(Panel.Location.X - 5, Panel.Location.Y);
                if (Panel.Location.X <=500)
                {
                    PanelButton.Text = ">";
                    PanelTimer2.Stop();
                    isHide = false;
                    this.Refresh();
                }
            }
            else
            {
                Panel.Location = new Point(Panel.Location.X + 5, Panel.Location.Y);
                if (Panel.Location.X >= 1000)
                {
                    PanelButton.Text = "<";
                    PanelTimer2.Stop();
                    isHide = true;
                    this.Refresh();
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelTimer2.Start();
        }
    }
}
