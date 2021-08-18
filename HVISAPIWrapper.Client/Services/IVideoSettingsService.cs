using HVISAPIWrapper.Shared;
using System.Threading.Tasks;

namespace HVISAPIWrapper.Client.Services
{
    public interface IVideoSettingsService
    {
        Task<ImageChannel> GetVideoSettings(int channel);
        Task<HIKResponse> SetVideoSettings(int channel, ImageChannel imageChannel);
    }
}
