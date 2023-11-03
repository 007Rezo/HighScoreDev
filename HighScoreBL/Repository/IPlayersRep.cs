
using HighScoreModels;
using HighScoreModels.ViewModels;


namespace HighScoreBL.Repos
{
    public interface IPlayersRep
    {
        void Add(Player player);
        bool Remove(Player player);
        bool Remove(int PlayerID);
        void Update(Player player);
        
        
        Player? getPlayer(int playerID);
        // zwei Listen kombinieren
        List<PlayerPerGame> getAllPlayers();
        List<PlayerPerGame> getPlayers(int gameID);
        //List<PlayerPerGame> removePlayers();
        //List<PlayerPerGame> addPlayers();
        //List<PlayerPerGame> updatePlayers();
    }
}
