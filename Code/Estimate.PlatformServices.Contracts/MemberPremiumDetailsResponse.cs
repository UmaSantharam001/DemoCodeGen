using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class MemberPremiumDetailsResponse
    {
        public double CurrentBalance  { get; set; }
        public string PaymentType  { get; set; }
        public double CurrentPremiumInclPenalty  { get; set; }
        public double CurrentPremium  { get; set; }
        public double CurrentMemberAmount  { get; set; }
        public double CurrentNonMemberAmount  { get; set; }
        public double CurrentLIS  { get; set; }
        public double CurrentSPAP  { get; set; }
        public double CurrentSSA  { get; set; }
        public double CurrentPenalty  { get; set; }
        public bool IsNextYearAvailable  { get; set; }
        public double NextPremiumInclPenalty  { get; set; }
        public double NextPremium  { get; set; }
        public double NextMemberAmount  { get; set; }
        public double NextNonMemberAmount  { get; set; }
        public double NextLIS  { get; set; }
        public double NextSPAP  { get; set; }
        public double NextSSA  { get; set; }
        public double NextPenalty  { get; set; }
    }

}
