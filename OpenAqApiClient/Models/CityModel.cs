using System;
using System.Collections.Generic;

namespace OpenAqApiClient.Models
{
    public class CityRoot
    {
        public MetaModel Meta { get; set; }

        public List<CityModel> Results { get; set; }
    }
    
    public class CityModel
    {
        public string Country { get; set; }
        
        public string City { get; set; }
        
        public int Count { get; set; }
        
        public int Locations { get; set; }
        
        public DateTime FirstUpdated { get; set; }

        public DateTime LastUpdated { get; set; }
        
        public List<string> Parameters { get; set; }
    }
}