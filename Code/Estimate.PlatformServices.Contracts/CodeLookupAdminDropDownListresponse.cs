using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class CodeLookupAdminDropDownListresponse
    {
        public IEnumerable<string> DisenrollmentCodes  { get; set; }
        public IEnumerable<string> RequestLocations  { get; set; }
    }

}
