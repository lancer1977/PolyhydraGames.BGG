using NUnit.Framework;
using PolyhydraGames.BGG;
using PolyhydraGames.BGG.Models;

namespace PolyhydraGames.BGG.Test
{
    public class Tests
    {
        [Test]
        public void SearchParameters_Encode_UsesExpectedQueryShape()
        {
            var parameters = new SearchParameters("dragon", exact: true);

            Assert.That(parameters.Encode(), Is.EqualTo("?exact=1?filter=dragon"));
        }

        [Test]
        public void BoardGameParameters_Encode_UsesExpectedQueryShape()
        {
            var parameters = new BoardGameParameters(82687, comments: true);

            Assert.That(parameters.Encode(), Is.EqualTo("?gameid=82687?comments=True"));
        }

        [Test]
        public void Endpoint_Surfaces_BGGApiRoots()
        {
            Assert.That(Endpoint.Search(), Is.EqualTo("https://www.boardgamegeek.com/xmlapi/search"));
            Assert.That(Endpoint.Guild(), Is.EqualTo("https://www.boardgamegeek.com/xmlapi/guild"));
            Assert.That(Endpoint.Thing(), Is.EqualTo("https://www.boardgamegeek.com/xmlapi/thing"));
        }
    }
}
