using System.Collections.Generic;
using System.Diagnostics;

namespace PolyhydraGames.BGG.Models
{
    public abstract class Parameters 
    {
        protected List<Param> _params = new();
        public string Encode()
        {
            var encoded = string.Empty;
            foreach (var item in _params)
            {
                encoded += item.Encode();
            }

            Debug.WriteLine(encoded);
            return encoded;
        }
    }
}