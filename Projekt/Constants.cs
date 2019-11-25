using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Constants
    {
        public static string API_KEY = APIRequest();
        public const string summonerBasePath = "summoner/v4";
        public const string leagueBasePath = "league/v4";
        public const string platformId = "eun1";

        /// <summary>
        /// Pobieranie unikatowego klucza API.
        /// --- UWAGA! ---
        /// Ważność klucza wynosi 24 godziny przez co trzeba go aktualizować w pliku tekstowym przed uruchomieniem.
        /// Klucz można odnowić na stronie https://developer.riotgames.com/.
        /// </summary>

        public static string APIRequest()
        {          
            StreamReader sr = new StreamReader("../../API_KEY.txt");
            return sr.ReadLine();
        }

    }
}
