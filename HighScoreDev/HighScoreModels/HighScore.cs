using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreModels
{
    public class HighScore
    {
        public int GameID { get; set; }
        public int PlayerID { get; set; }
        public int Score { get; set; }
        public DateTime ScoreDate { get; set; }

        public void Add(HighScore highscore)
        {
            throw new NotImplementedException();
        }

        public bool SelectSingleNode(string v)
        {
            throw new NotImplementedException();
        }
    }
}
