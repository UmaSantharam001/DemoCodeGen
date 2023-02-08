using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class PreEnrollment
    {
        public long RequestID  { get; set; }
        public int RequestType  { get; set; }
        public int RequestLocation  { get; set; }
        public string ReferralCode  { get; set; }
        public string FirstName  { get; set; }
        public string MI  { get; set; }
        public string LastName  { get; set; }
        public string Address1  { get; set; }
        public string Address2  { get; set; }
        public string City  { get; set; }
        public string State  { get; set; }
        public string ZipCode  { get; set; }
        public string Phone  { get; set; }
        public string CostcoCity  { get; set; }
        public string CostcoState  { get; set; }
        public string Representative  { get; set; }
        public string FollowUpName  { get; set; }
        public DateTime FollowUpDate  { get; set; }
        public bool SendPacket  { get; set; }
        public bool Enrolled  { get; set; }
        public bool FollowUp  { get; set; }
        public bool NoCallBack  { get; set; }
        public string Notes  { get; set; }
        public string EntryLocation  { get; set; }
        public DateTime CreatedDate  { get; set; }
        public DateTime ModifiedDate  { get; set; }
        public DateTime ExportDate  { get; set; }
        public DateTime CallExportDate  { get; set; }
        public bool Spanish  { get; set; }
    }

}
