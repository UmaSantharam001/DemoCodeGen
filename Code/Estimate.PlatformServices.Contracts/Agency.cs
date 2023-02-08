using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class Agency
    {
        public int AgencyId  { get; set; }
        public string AgencyName  { get; set; }
        public string TaxId  { get; set; }
        public string NPN  { get; set; }
        public string AgencyCode  { get; set; }
        public DateTime AgencyStart  { get; set; }
        public DateTime AgencyEnd  { get; set; }
        public string AgencyStatus  { get; set; }
        public string AgencyType  { get; set; }
    }

}
