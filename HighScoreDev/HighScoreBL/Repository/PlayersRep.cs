using HighScoreModels;
using HighScoreModels.ViewModels;
using HighScoreDAL;


namespace HighScoreBL.Repos
{
    public class PlayersRep : IPlayersRep
    {
       

        public PlayersRep(HsDal hsDal)
        {
            dal = hsDal;
        }
        private HsDal dal;

        public Player? getPlayer(int playerID)
        {

            Player? player =  dal.Players.FirstOrDefault(w => w.playerID == playerID);
            return player;
        }
        List<PlayerPerGame> IPlayersRep.getPlayers(int gameID)
        {
            throw new NotImplementedException();
        }
        public List<PlayerPerGame> getAllPlayers(int gameID)
        {
            // wenn nicht alle Daten aus einer Liste ausgegeben werden
            var players = from p in dal.Players
                          where p.isActive == true
                          orderby p.NickName
                          select new PlayerPerGame
                          {
                              PlayerID = p.PlayerID,
                              Email = p.Email,
                              NickName = p.NickName,
                          };

            return players.ToList();
        }

        public void Add(Player player)
        {
            int nextID;
            try
            {
                nextID =  dal.Players.Max(w => w.playerID) +1 ;
            }catch(InvalidOperationException e)
            {
                nextID = 1;
            }
            player.PlayerID = nextID;
            dal.Players.Add(player);
        }
        public bool Remove(Player player)
        {
            throw new NotImplementedException();
        }
        public bool Remove(int playerID)
        {
            Player? player = getPlayer(playerID);
            if(player != null)
            {
                return dal.Players.Remove(player);
            }
            return false;
        }
        public void Update(Player player)
        {
            Player? p = dal.Players.FirstOrDefault(w => w.PlayerID == player.PlayerID);
            if(p != null)
            {
                p.FName    = player.FName;
                p.NickName = player.NickName;
                p.BirthDay = player.BirthDay;
                p.NickName = player.NickName;
                p.isActive = player.isActive;
                p.Email    = player.Email;
                p.Entry    = player.Entry;
                p.Exit     = player.Exit;
                p.Notes    = player.Notes;
            }
        }

        public List<PlayerPerGame> getAllPlayers()
        {
            throw new NotImplementedException();
        }
    }
}
