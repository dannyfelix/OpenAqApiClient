using System.Collections.Generic;

namespace OpenAqApiClient.Models
{
    public class LatestRoot
    {
        public MetaModel Meta { get; set; }

        public LatestModel[] Results { get; set; }
    }
    
    public class LatestModel
    {
        public string Location { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public CoordinateModel Coordinates { get; set; }
        
        public List<MeasurementModel> Measurements { get; set; } 
    }
}