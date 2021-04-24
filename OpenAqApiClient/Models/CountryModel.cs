using System;
using System.Collections.Generic;

namespace OpenAqApiClient.Models
{
    public class CountryRoot
    {
        public MetaModel Meta { get; set; }
        
        public List<CountryModel> Results { get; set; }
    }
    
    public class CountryModel
    {
        public string Code { get; set; }
        
        public string Name { get; set; }
        
        public int Locations { get; set; }

        public DateTime FirstUpdated { get; set; }

        public DateTime LastUpdated { get; set; }
            
        public List<ParameterModel> Parameters { get; set; }

        public int Count { get; set; }
        
        public int Cities { get; set; }

        public int Sources { get; set; }
    }
}