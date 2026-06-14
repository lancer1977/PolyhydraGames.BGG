using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using PolyhydraGames.BGG.Models;
using PolyhydraGames.Core.Global;
using PolyhydraGames.Core.Global.Helpers;

namespace PolyhydraGames.BGG
{
    public static class BGGApi
    {

        /*
            
            https://www.rpggeek.com/xmlapi2/
                https://www.videogamegeek.com/xmlapi2/

         */


        public static async Task<object> GetBoardGame(int id)
        {
            var parameter = new BoardGameParameters(id);
            return await GetWebResponse<object>(Endpoint.Guild() + parameter.Encode());
        }

        public static async Task<object> GetGuild(int id)
        {
            var parameter = new GuildParameters(id);
            return await GetWebResponse<object>(Endpoint.Guild() + parameter.Encode());
        }
        public static async Task<object> GetThing(int id)
        {
            var parameter = new ThingParameters(id);
            return await GetWebResponse<object>(Endpoint.Thing() + parameter.Encode());
        }

        public static async Task<object> Search(string value,bool exact = false)
        {
            var parameter = new SearchParameters(value,exact);
            return await GetWebResponse<object>(Endpoint.Search() + parameter.Encode());
        }
 
        public static async Task<T> GetWebResponse<T>(string url)
        {
            try
            {
                var response = await WebHelpers.GetString(url);
                var t = response.FromJson<T>();
                return t;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return default(T);
            }
        }
 


    }
}
