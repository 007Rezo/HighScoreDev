using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreModels.ViewModels
{
    public class PlayerPerGame
    {
        public int PlayerID { get; set; }
        public string NickName { get; set; } = string.Empty; 
        public string Email { get; set; } = string.Empty;
    }
}
