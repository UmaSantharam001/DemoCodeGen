using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class PrimaryPharmacy
    {
        public int PharmacyId  { get; set; }
        public string NABP  { get; set; }
        public string ChainCode  { get; set; }
        public string Name  { get; set; }
        public int PharmacyTypeId  { get; set; }
        public string Phone  { get; set; }
        public bool IsPrimary  { get; set; }
        public bool IsPreferred  { get; set; }
        public bool IsEPrescribing  { get; set; }
        public bool IsEIC  { get; set; }
        public bool IsEGWP  { get; set; }
        public bool IsPreferredCC  { get; set; }
        public bool Is90DayRetail  { get; set; }
        public int MemberPharmacyID  { get; set; }
        public int Distance  { get; set; }
        public int Year  { get; set; }
        public int PreferenceType  { get; set; }
        public bool IsBrokerPbp  { get; set; }
    }
}
