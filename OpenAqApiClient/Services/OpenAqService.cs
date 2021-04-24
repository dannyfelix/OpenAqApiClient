using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OpenAqApiClient.Models;
using OpenAqApiClient.Services.Interfaces;

namespace OpenAqApiClient.Services
{
    public class OpenAqService : IOpenAqService
    {
        private readonly HttpClient _client;
        private readonly ILogger<OpenAqService> _logger;

        public OpenAqService(IHttpClientFactory httpClientFactory, ILogger<OpenAqService> logger)
        {
            _client = httpClientFactory.CreateClient("OpenAqV2");
            _logger = logger;
        }

        public async Task<LatestRoot> GetLatestCity(string city)
        {
            try
            {
                return await _client.GetFromJsonAsync<LatestRoot>($"latest?city={city}");
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occured while attempting to retrieve results for {city}: {ex.Message}");
                return new LatestRoot();
            }
        }
    }
}