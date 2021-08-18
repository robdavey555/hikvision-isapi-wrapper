using HVISAPIWrapper.Shared;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace HVISAPIWrapper.Test.DataFactories
{
    public static class VideoSettingsFactory
    {
        public static ImageChannel GetImageChannel()
        {
            var result = new ImageChannel()
            {
                id = 1,
                enableImageLossDetection = false,
                imageMode = "standard",
                Color = new Color()
                {
                    brightnessLevel = 100,
                    contrastLevel = 100,
                    hueLevel = 100,
                    saturationLevel = 100,
                    sharpnessLevel = 10
                },
                inputPort = 1,
                NoiseReduce = new NoiseReduce()
                {
                    mode = "general",
                    GeneralMode = new GeneralMode()
                    {
                        generalLevel = 1
                    }
                }
            };

            //XmlSerializer xsSubmit = new XmlSerializer(typeof(ImageChannel));
            //var subReq = new ImageChannel();
            //var xml = "";

            //using (var sww = new StringWriter())
            //{
            //    using (XmlWriter writer = XmlWriter.Create(sww))
            //    {
            //        xsSubmit.Serialize(writer, result);
            //        xml = sww.ToString(); // Your XML
            //    }
            //}

            return result;
        }

        public static T XmlDeserialize<T>(this string toDeserialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (StringReader textReader = new StringReader(toDeserialize))
            {
                return (T)xmlSerializer.Deserialize(textReader);
            }
        }
    }

    

}
