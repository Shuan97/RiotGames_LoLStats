using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Projekt
{
    [Serializable]
    class WebServiceHandler
    {
        private static readonly string _summonerBasePath = Constants.summonerBasePath;
        private static readonly string _leagueBasePath = Constants.leagueBasePath;
        private static readonly string _api = Constants.API_KEY;
        private static string _appPath;

        public static string HTTPBuilder(string resource)
        {
            string platformId = Constants.platformId;

            var resourceBuilder = new StringBuilder();
            resourceBuilder
                .Append("https://")
                .Append(platformId.ToLowerInvariant())
                .Append(".api.riotgames.com/lol/")
                .Append(resource);
            return resourceBuilder.ToString();
        }

        public static Summoner GetSummoner(string name)
        {
            string json;
            try
            {
                json = new WebClient().DownloadString(HTTPBuilder(_summonerBasePath + "/summoners/by-name/" + name + "?api_key=" + _api));
            }
            catch (Exception)
            {
                Console.WriteLine("Nie znaleziono");
                return null;
            }
            Console.WriteLine(json);
            Summoner summoner = JsonConvert.DeserializeObject<Summoner>(json);
            SaveJson(json);
            return summoner;
        }

        public static Tuple<LeagueTT, LeagueFlex, LeagueSolo> GetLeague(string id)
        {
            string json = new WebClient().DownloadString(HTTPBuilder(_leagueBasePath + "/entries/by-summoner/"+ id +"?api_key=" + _api));
            Console.WriteLine(json);
            JArray j = JArray.Parse(json);
            LeagueTT LTT = null;
            LeagueFlex LFlex = null;
            LeagueSolo LSolo = null;
            try
            {
                JObject LeagueTT = j[0].ToObject<JObject>();
                LTT = JsonConvert.DeserializeObject<LeagueTT>(LeagueTT.ToString());
            }
            catch (Exception)
            {

            }
            try
            {
                JObject LeagueFlex = j[1].ToObject<JObject>();
                LFlex = JsonConvert.DeserializeObject<LeagueFlex>(LeagueFlex.ToString());
            }
            catch (Exception)
            {

            }

            try
            {
                JObject LeagueSolo = j[2].ToObject<JObject>();
                LSolo = JsonConvert.DeserializeObject<LeagueSolo>(LeagueSolo.ToString());
            }
            catch (Exception)
            {

            }
            return Tuple.Create(LTT, LFlex, LSolo);
        }

        public static List<GameIds> GetMatchesId(string accountId)
        {
            string json = new WebClient().DownloadString(HTTPBuilder("match/v4/matchlists/by-account/" + accountId + "?api_key=" + _api));
            Console.WriteLine(json);
            JObject r = JObject.Parse(json);
            List<JToken> results = r["matches"].Children().ToList();
            List<GameIds> searchResults = new List<GameIds>();
            foreach (JToken result in results)
            {
                GameIds searchResult = result.ToObject<GameIds>();
                searchResults.Add(searchResult);
            }
            return searchResults;
        }
        
        public static Match GetMatch(string matchId)
        {
            string json = new WebClient().DownloadString(HTTPBuilder("match/v4/matches/" + matchId.ToString() + "?api_key=" + _api));
            Match match = JsonConvert.DeserializeObject<Match>(json);
            return match;
        }

        public static string GetAppPath()
        {
            if (String.IsNullOrEmpty(_appPath))
                _appPath = AddSepChar(Application.StartupPath);

            return _appPath;
        }

        public static string GetSavePath()
        {
            string path = AddSepChar(Path.Combine(GetAppPath(), "Saves"));
            if (Directory.Exists(path) == false)
                Directory.CreateDirectory(path);

            return path;
        }

        public static string GetNewSave()
        {
            return Path.Combine(GetSavePath(),
                DateTime.Now.ToString("dd.MM.yyyy-HHmmss-", System.Globalization.CultureInfo.InvariantCulture)+".txt");
        }

        private static string AddSepChar(string path)
        {
            if (path.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.OrdinalIgnoreCase))
                path += Path.DirectorySeparatorChar.ToString();

            return path;
        }

        private static void SaveJson(string json)
        {
            using (StreamWriter sw = new StreamWriter(GetNewSave()))
            {
                sw.WriteLine(json);
            }
        }
    }
}
