using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreModels
{
    public class Player : Details
    {
        public int playerID;

        public int PlayerID { get; set; }
        public string NickName { get; set; } = string.Empty; // darf nicht ohne NickName spielen

        public string Email { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; }
        public string FName { get; set; } = string.Empty;
        public string LName { get; set; } = string.Empty;

    }
}
