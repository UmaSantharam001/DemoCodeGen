using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class Log
    {
        public int Id  { get; set; }
        public int MemberId  { get; set; }
        public string CreatedDate  { get; set; }
        public string TransactionId  { get; set; }
        public bool Approved  { get; set; }
        public string Origin  { get; set; }
    }
}
