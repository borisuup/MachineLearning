using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iStoreApi.Models
{
    public class Transaction
    {
        public long PinSaleTransactionKey { get; set; }
        public string TransId { get; set; }
        public decimal TransAmt { get; set; }
        public DateTime TransDate { get; set; }
    }
}