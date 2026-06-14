using System.Xml.Serialization;

namespace PolyhydraGames.BGG.Models
{
 
 

    [XmlRoot(ElementName = "location")]
    public class Location
    {
        [XmlElement(ElementName = "addr1")]
        public string Addr1 { get; set; }
        [XmlElement(ElementName = "addr2")]
        public string Addr2 { get; set; }
        [XmlElement(ElementName = "city")]
        public string City { get; set; }
        [XmlElement(ElementName = "stateorprovince")]
        public string Stateorprovince { get; set; }
        [XmlElement(ElementName = "postalcode")]
        public string Postalcode { get; set; }
        [XmlElement(ElementName = "country")]
        public string Country { get; set; }
    }

    [XmlRoot(ElementName = "guild")]
    public class Guild
    {
        [XmlElement(ElementName = "category")]
        public string Category { get; set; }
        [XmlElement(ElementName = "website")]
        public string Website { get; set; }
        [XmlElement(ElementName = "manager")]
        public string Manager { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "location")]
        public Location Location { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "created")]
        public string Created { get; set; }
        [XmlAttribute(AttributeName = "termsofuse")]
        public string Termsofuse { get; set; }
    }

}