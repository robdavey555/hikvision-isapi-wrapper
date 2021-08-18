using Flurl;
using Flurl.Http;
using Flurl.Http.Xml;
using HVISAPIWrapper.Shared;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HVISAPIWrapper.Client.Services
{
    public class VideoSettingsService : HIKISAPIClient, IVideoSettingsService
    {
        private const string requestPath = "/ISAPI/Image/channels/";
        HIKISAPIClientConfiguration _configuration;
        public VideoSettingsService(HIKISAPIClientConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public async Task<ImageChannel> GetVideoSettings(int channel)
        {
            using (var x = new HttpClient(CreateMessageHandler()))
            {
                string Url = _configuration.GetUrl();
                var result = await Url.WithClient(new FlurlClient(x))
                                      .AppendPathSegment($"{requestPath}{channel}")
                                      .GetStringAsync();

                var imageChannel = (ImageChannel)new XmlSerializer(typeof(ImageChannel), "http://www.hikvision.com/ver20/XMLSchema").Deserialize(new StringReader(result));

                return imageChannel;
            }
        }

        public async Task<HIKResponse> SetVideoSettings(int channel, ImageChannel imageChannel)
        {
            using (var x = new HttpClient(CreateMessageHandler()))
            {
                string Url = _configuration.GetUrl();
                var result = await Url.WithClient(new FlurlClient(x))
                                      .AppendPathSegment($"{requestPath}{channel}")                                      
                                      .PutXmlAsync(imageChannel)                                      
                                      .ReceiveString();

                var response = (HIKResponse)new XmlSerializer(typeof(HIKResponse), "http://www.hikvision.com/ver20/XMLSchema").Deserialize(new StringReader(result));

                return response;
            }           
        }

        private HttpMessageHandler CreateMessageHandler()
        {
            var credCache = new CredentialCache();
            credCache.Add(new Uri(_configuration.GetUrl()), "Digest", new NetworkCredential(_configuration.UserName, _configuration.Password));

            var handler = new HttpClientHandler
            {
                Credentials = credCache
            };
            return handler;
        }
    }
}
