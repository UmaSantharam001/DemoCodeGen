using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class Memberresponse
    {
        public int MemberId  { get; set; }
        public int PlanId  { get; set; }
        public string PlanName  { get; set; }
        public string GroupId  { get; set; }
        public string AltMemberId  { get; set; }
        public string HICN  { get; set; }
        public string MBI  { get; set; }
        public string MedicareNumber  { get; set; }
        public string FirstName  { get; set; }
        public string LastName  { get; set; }
        public string Prefix  { get; set; }
        public string MiddleInitial  { get; set; }
        public string Address1  { get; set; }
        public string Address2  { get; set; }
        public string City  { get; set; }
        public string State  { get; set; }
        public string ZipCode  { get; set; }
        public string MAddress1  { get; set; }
        public string MAddress2  { get; set; }
        public string MCity  { get; set; }
        public string MState  { get; set; }
        public string MZipCode  { get; set; }
        public string DOB  { get; set; }
        public string Gender  { get; set; }
        public string Email  { get; set; }
        public string Phone  { get; set; }
        public string CellPhone  { get; set; }
        public string AltPhone  { get; set; }
        public string BWritingCode  { get; set; }
        public IEnumerable<string> Pharmacies  { get; set; }
        public int MonthlyPremium  { get; set; }
        public int CurrentBalance  { get; set; }
        public string EnrollmentDate  { get; set; }
        public string DisenrollmentDate  { get; set; }
        public string PbpCode  { get; set; }
        public int PbpId  { get; set; }
        public int Year  { get; set; }
        public int GreenEobReasonCode  { get; set; }
        public string CMSConfirmationID  { get; set; }
        public string MailNABPs  { get; set; }
        public bool IsBroker  { get; set; }
        public bool BrokerAttestation  { get; set; }
        public int BrokerID  { get; set; }
        public string Status  { get; set; }
        public bool EGWPDirectBill  { get; set; }
    }
}
