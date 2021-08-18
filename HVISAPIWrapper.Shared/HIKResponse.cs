using System.Xml.Serialization;

namespace HVISAPIWrapper.Shared
{
    [XmlRoot(ElementName = "ResponseStatus")]
    public class HIKResponse
    {
        public string requestURL { get; set; }
        public int statusCode { get; set; }
        public string statusString { get; set; }
        public string subStatusCode { get; set; }
    }
}
