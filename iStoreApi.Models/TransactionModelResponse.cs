
using Newtonsoft.Json;

namespace iStoreApi.Models
{
    public class TransactionModelResponse
    {
        public TransactionModelResults Results { get; set; }
    }

    public class TransactionModelResults
    {
        public TransactionModelOutput[] Output { get; set; }
    }

    public class TransactionModelOutput
    {
        public string PinSaleTransactionKey { get; set; }
        public string TransId { get; set; }
        public string TransAmt { get; set; }
        public string TransDate { get; set; }
        public string TransAmt_zScore { get; set; }
        public string Minutes { get; set; }
        public string Minutes_zScore { get; set; }
        public string Duration { get; set; }
        public string Duration_zScore { get; set; }
        public string Assignments { get; set; }
        [JsonProperty(PropertyName = "DistancesToClusterCenter no.0")]
        public string DistancesToClusterCenterno0 { get; set; }
        [JsonProperty(PropertyName = "DistancesToClusterCenter no.1")]
        public string DistancesToClusterCenterno1 { get; set; }
    }
    
}
