using PolyhydraGames.Extensions;

namespace PolyhydraGames.BGG.Models
{
    public class GuildParameters : Parameters
    {
        
        public GuildParameters(int id = -1, int members = -1, GuildSort sort = GuildSort.None, int page = 1)
        { 
            if (id != -1) _params.Add(new Param("id", id));
            if (members != -1) _params.Add(new Param("members", members));

            if (sort != GuildSort.None) _params.Add(new Param("sort", sort.ToInt()));
            if (page != 1) _params.Add(new Param("page", page));

        }

      
    }

    public class ThingParameters : Parameters
    {

        public ThingParameters(int id = -1, int members = -1, GuildSort sort = GuildSort.None, int page = 1)
        {
            if (id != -1) _params.Add(new Param("id", id));
            if (members != -1) _params.Add(new Param("members", members));

            if (sort != GuildSort.None) _params.Add(new Param("sort", sort.ToInt()));
            if (page != 1) _params.Add(new Param("page", page));

        }


    }
}