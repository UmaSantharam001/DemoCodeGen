using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class GeoAddress
    {
        public string Latitude  { get; set; }
        public string Longitude  { get; set; }
        public string Address1  { get; set; }
        public string Address2  { get; set; }
        public string City  { get; set; }
        public string StateCode  { get; set; }
        public string ZipCode  { get; set; }
    }

}
