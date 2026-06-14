namespace PolyhydraGames.BGG.Models
{
    public class BoardGameParameters : Parameters
    {

        public BoardGameParameters(int gameid = -1, bool comments = false, bool stats = false, bool historical = false)
        {
            if (gameid != -1) _params.Add(new Param("gameid", gameid));
            if (comments) _params.Add(new Param("comments", comments)); 
            if (stats) _params.Add(new Param("stats", stats));
            if (historical)  _params.Add(new Param("historical", historical));

        }


    }
}