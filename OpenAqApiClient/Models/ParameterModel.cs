using System;

namespace OpenAqApiClient.Models
{
    public class ParameterModel
    {
        public int Id { get; set; }
        
        public string Unit { get; set; }
        
        public int Count { get; set; }
        
        public float Average { get; set; }
        
        public float LastValue { get; set; }
        
        public string Parameter { get; set; }
        
        public string DisplayName { get; set; }
        
        public DateTime LastUpdated { get; set; }
        
        public int ParameterId { get; set; }
        
        public DateTime FirstUpdated { get; set; }
    }
}