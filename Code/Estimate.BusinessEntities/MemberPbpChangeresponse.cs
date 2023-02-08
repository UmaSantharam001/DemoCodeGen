using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class MemberPbpChangeresponse
    {
        public string id  { get; set; }
        public int rowsAffected  { get; set; }
        public string lastUpdatedDate  { get; set; }
        public int actionSetCount  { get; set; }
        public string nextCardId  { get; set; }
        public bool success  { get; set; }
        public int statusCode  { get; set; }
        public IEnumerable<string> actionSetErrors  { get; set; }
        public IEnumerable<string> errors  { get; set; }
        public IEnumerable<string> truthTableErrors  { get; set; }
        public IEnumerable<string> userMessages  { get; set; }
    }
}
