using System;
using System.Collections.Generic;
namespace PolyhydraGames.BGG
{
    public static class Endpoint
    {
        private static string _prefix2 = "https://www.boardgamegeek.com/xmlapi2/";
        private static string _prefix = "https://www.boardgamegeek.com/xmlapi/";

        public static string Thing() => $"{_prefix}thing";
        public static string BoardGameExpansion() => $"{_prefix}boardgameexpansion";
        public static string BoardGameAccessory() => $"{_prefix}boardgameaccessory";
        public static string VideoGame() => $"{_prefix}videogame";
        public static string RpgItem() => $"{_prefix}rpgitem";
        public static string RpgIssue() => $"{_prefix}rpgissue";
        public static string Guild() => $"{_prefix}guild";
        public static string Search() => $"{_prefix}search";

    }
}