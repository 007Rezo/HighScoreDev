using HighScoreBL.Repos;
using HighScoreDAL;


namespace HighScoreBL
{

    public class UnitOfWork
    {

        private PlayersRep? playersRep;
        private readonly HsDal dal = new HsDal();
        private readonly FileType Filetype;

        public UnitOfWork(FileType fileType = FileType.json)
        {
            FileType = fileType;
            dal = FileType switch 
            { 
                FileType
            }
        }




        public PlayersRep Players
        {       
             get { return playersRep ??= new PlayersRep(dal); } 
        }
        public int Commit()
        {
            return dal.Save();
        }
        public void Rollback()
        {

        }
       
    }
}
