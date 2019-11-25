using System.Collections.Generic;

namespace Projekt
{
    class Match
    {
        public class Team
        {
            public int teamId { get; set; }
            public string win { get; set; }
        }

        public class Stats
        {
            public int participantId { get; set; }
            public bool win { get; set; }
            public int item0 { get; set; }
            public int item1 { get; set; }
            public int item2 { get; set; }
            public int item3 { get; set; }
            public int item4 { get; set; }
            public int item5 { get; set; }
            public int item6 { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
        }

    public class Participant
    {
        public int participantId { get; set; }
        public int teamId { get; set; }
        public int championId { get; set; }
        public Stats stats { get; set; }
    }

    public class Player
    {
        public string platformId { get; set; }
        public string accountId { get; set; }
    }

    public class ParticipantIdentity
    {
        public int participantId { get; set; }
        public Player player { get; set; }
    }


    public long gameId { get; set; }
    public List<Team> teams { get; set; }
    public List<Participant> participants { get; set; }
    public List<ParticipantIdentity> participantIdentities { get; set; }
    }
}
