namespace HVISAPIWrapper.Client
{
    public class HIKISAPIClientConfiguration
    {
        public string DeviceUrl { get; set; }

        public string Port { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Scheme { get; set; } = "http";

        public string GetUrl()
        {
            return $"{Scheme}://{ DeviceUrl }:{ Port }/";
        }
    }
}
