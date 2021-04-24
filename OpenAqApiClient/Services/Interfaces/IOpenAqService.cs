using System.Collections.Generic;
using System.Threading.Tasks;
using OpenAqApiClient.Models;

namespace OpenAqApiClient.Services.Interfaces
{
    public interface IOpenAqService
    {
        Task<LatestRoot> GetLatestCity(string city);
    }
}