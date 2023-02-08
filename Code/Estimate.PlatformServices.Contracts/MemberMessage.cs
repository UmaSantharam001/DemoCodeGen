using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class MemberMessage
    {
        public int MessageId  { get; set; }
        public string Title  { get; set; }
        public string Content  { get; set; }
        public string Link  { get; set; }
        public string LinkText  { get; set; }
        public string LanguageType  { get; set; }
        public double DefaultOrder  { get; set; }
        public string Image  { get; set; }
        public DateTime StartDate  { get; set; }
        public DateTime EndDate  { get; set; }
        public string UserName  { get; set; }
    }

}
