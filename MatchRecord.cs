using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arc
{
    public class MatchRecord
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public string RaiderName { get; set; } = string.Empty;
        public double AggroScore { get; set; }
        public double ScoreDifference { get; set; }
        public string PredictedLobby { get; set; } = string.Empty;
        public double Downed { get; set; }
        public double KnockedOut { get; set; }
        public double Revives { get; set; }
        public double DmgDealt { get; set; }
        public double DmgReceived { get; set; }
        public double Looted { get; set; }
    }
}