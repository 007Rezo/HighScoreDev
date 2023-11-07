using HighScoreModels;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HighScoreDAL
{
    public class HsDALJson : HsDal
    {
        public override int Save()
        {
            throw new NotImplementedException();
        }
        protected override List<Game>LoadGames()
        {
            throw new NotImplementedException();
        }
        protected override List<HighScore> LoadHighScores()
        {
            throw new NotImplementedException();
        }
        protected override List<Player> LoadPlayers()
        {
            throw new NotImplementedException();
        }
    }
    //if(games is not null)
    private static void ParseHighScores(List<HightScore> highscores, XMLNode highscoreNode)
    {
        HighScore highscore = new HighScore();
        highscore.GameID = Convert.ToInt32(highscore.SelectSingleNode("GameId")?.InnerText);
        highscore.GameID = Convert.ToInt32(highscore.SelectSingleNode("PlayerId")?.InnerText);
        highscore.GameID = Convert.ToInt32(highscore.SelectSingleNode("Score")?.InnerText);
        highscore.GameID = Convert.ToInt32(highscore.SelectSingleNode("ScoreDate")?.InnerText);

        highscore.Add(highscore);
    }
    private static void ParsePlayer(List<Player> players, XmlNode playerNode, Player player)
    {
        Player player = new Player();

        player.PlayerId = Convert.ToInt32(playerNode, SelectSingleNode("PlayerId")!.InnerText);
        player.Nickname = playerNode.SelectSingleNode("Nickname")!.InnerText;
        player.Email = playerNode.SelectSingleNode("Email")!.InnerText;
        player.Birthday = DateTime.Parse(playerNode, SelectSingleNode("Birthday")!.InnerText);
        player.FirstName  = Convert.ToInt32(playerNode, SelectSingleNode("FirstName")!.InnerText);
        player.LastName = Convert.ToInt32(playerNode, SelectSingleNode("LastName")!.InnerText);
        player.LastName = Convert.ToInt32(playerNode, SelectSingleNode("LastName")!.InnerText);
        player.Entry = DateTime.Parse(playerNode, SelectSingleNode("Entry")!.InnerText);
        player.Exit = DateTime.Parse(playerNode, SelectSingleNode("Exit")!.InnerText);
        player.isActive = Convert.ToBoolean(playerNode, SelectSingleNode("IsActive")!.InnerText);
        player.Notes = playerNode, SelectSingleNode("Notes")!.InnerText;



    }

    object SelectSingleNode(string v)
    {
        throw new NotImplementedException();
    }
}
