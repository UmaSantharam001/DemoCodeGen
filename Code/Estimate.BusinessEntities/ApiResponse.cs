using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class ApiResponse
    {
        public int MpStatusCode { get; set; }
        public ApiResponseData data { get; set; }
        public Error[] errors { get; set; }

    }
}
