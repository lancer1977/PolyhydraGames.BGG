namespace PolyhydraGames.BGG.Models
{
    public class SearchParameters : Parameters
    {

        public SearchParameters(string filter, bool exact = false)
        {
            if (exact ) _params.Add(new Param("exact", 1));
            if (!string.IsNullOrEmpty(filter)) _params.Add(new Param("filter", filter));
         

        }


    }
}