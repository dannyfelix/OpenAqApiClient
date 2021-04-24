using System;
using System.Collections.Generic;

namespace OpenAqApiClient.Models
{
    public class LocationRoot
    {
        public MetaModel Meta { get; set; }

        public List<LocationModel> Results { get; set; }
    }
    
    public class LocationModel
    {
        public int Id { get; set; }

        public string City { get; set; }

        public string Name { get; set; }
        
        public string Entity { get; set; }
        
        public string Country { get; set; }
        
        public List<SourceModel> Sources { get; set; }
        
        public bool IsMobile { get; set; }
        
        public bool IsAnalysis { get; set; }
        
        public List<ParameterModel> Parameters { get; set; }
        
        public string SensorType { get; set; }
        
        public CoordinateModel Coordinates { get; set; }
        
        public DateTime LastUpdated { get; set; }
        
        public DateTime FirstUpdated { get; set; }
        
        public int Measurements { get; set; }
        
    }
}