using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class Note
    {
        public string itemId  { get; set; }
        public string typeId  { get; set; }
        public string typeDescription  { get; set; }
        public string text  { get; set; }
        public string createdBy  { get; set; }
        public string createdOn  { get; set; }
    }

}
