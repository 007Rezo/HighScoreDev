using HighScoreModels;
using System.Text.Json;

namespace HighScoreDAL
{
    public class HsDal : IHsDal
    {
        private List<Game>? games;
        private List<Player>? players;
        private List<HighScore>? highScores;

        public string FilePath { get; set; } = 
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\HighScore";
        public FileType FileType { get; set; } = FileType.json;
        // Reference Veraibl
        public List<Game> Games => games ??= LoadGames(); //only gets Loaded if List is null
        public List<Player> Players => players ??= LoadPlayers();
        public List<HighScore> HighScores => highScores ??= LoadHighScores()
        public abstract Task<int> Save()
        {
            switch (FileType)
            {
                case FileType.json: 
                    games = (JsonSerializer.Deserialize<List<Game>>(LoadJson());
                    saveJson();
                    break;
                case FileType.xml:
                    saveXML();
                    break;
                case FileType.csv:
                    saveCSV();
                    break;
                default:
                    break;
            }
            return (games is null ? 0 : games.Count()) +
            (players is null ? 0 : players.Count()) +
            (highScores is null ? 0 : highScores.Count());
        }

        protected abstract List<Game> LoadGames();

        protected abstract List<Player> LoadPlayers();

        protected abstract List<HighScore> LoadHighScores();
        
        private void saveJson()
        {
            throw new NotImplementedException();
        }
        private void saveXML()
        {
            throw new NotImplementedException();
        }
        private void saveCSV()
        {
            throw new NotImplementedException();
        }

    }

    //enum : 
    public enum FileType
    {
        json,
        csv,
        xml
    }
}


    

