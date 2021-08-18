using System.Xml.Serialization;

namespace HVISAPIWrapper.Shared
{
    //[XmlType(Namespace = "http://www.hikvision.com/ver20/XMLSchema")]
    [XmlRoot(Namespace = "http://www.hikvision.com/ver20/XMLSchema")]
    public class ImageChannel
    {
        public int id { get; set; }
        public int inputPort { get; set; }
        public NoiseReduce NoiseReduce { get; set; }
        public Color Color { get; set; }
        public string imageMode { get; set; }
        public bool enableImageLossDetection { get; set; }
        
    }
}
