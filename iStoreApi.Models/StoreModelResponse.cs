using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iStoreApi.Models
{
    public class StoreModelResponse
    {
        public StoreModelResults Results { get; set; }
    }
    public class StoreModelResults
    {
        public StoreModelOutput[] Output { get; set; }
    }

    public class StoreModelOutput
    {
        public string TransDate { get; set; }
        public string TotalTransAmt { get; set; }
        public string TransCount { get; set; }
        public string AvgTransAmt { get; set; }
        public string MaxTransAmt { get; set; }
        public string TotalTransAmt_zScore { get; set; }
        public string TransCount_zScore { get; set; }
        public string AvgTransAmt_zScore { get; set; }
        public string MaxTransAmt_zScore { get; set; }
        public string Assignments { get; set; }
        [JsonProperty(PropertyName = "DistancesToClusterCenter no.0")]
        public string DistancesToClusterCenterno0 { get; set; }
        [JsonProperty(PropertyName = "DistancesToClusterCenter no.1")]
        public string DistancesToClusterCenterno1 { get; set; }
    }

}
