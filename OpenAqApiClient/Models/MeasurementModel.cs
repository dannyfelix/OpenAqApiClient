using System;
using System.Collections.Generic;

namespace OpenAqApiClient.Models
{
    public class MeasurementRoot
    {
        public MetaModel Meta { get; set; }
        
        public List<MeasurementModel> Results { get; set; }
    }
    
    public class MeasurementModel
    {
        public int LocationId { get; set; }
        
        public string Location { get; set; }
        
        public string Parameter { get; set; }
        
        public int Value { get; set; }
        
        public DateModel Date { get; set; }
        
        public DateTime LastUpdated { get; set; } 
        
        public string Unit { get; set; }
        
        public CoordinateModel Coordinates { get; set; }
        
        public string Country { get; set; }
        
        public string City { get; set; }
        
        public bool IsMobile { get; set; }
        
        public bool IsAnalysis { get; set; }
        
        public string Entity { get; set; }
        
        public string SensorType { get; set; }
    }
}