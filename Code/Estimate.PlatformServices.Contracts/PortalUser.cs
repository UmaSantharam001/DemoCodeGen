using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class PortalUser
    {
        public long UserId  { get; set; }
        public string WritingCode  { get; set; }
        public long MemberId  { get; set; }
        public string UserName  { get; set; }
        public string Email  { get; set; }
        public string SecretImage  { get; set; }
        public int LoginAttempt  { get; set; }
        public string ResetGuid  { get; set; }
        public string Url  { get; set; }
        public bool IsValidUser  { get; set; }
        public string Phone  { get; set; }
        public bool HasAcceptedEula  { get; set; }
        public int PreferedContactMethod  { get; set; }
        public long PatientId  { get; set; }
        public string NPN  { get; set; }
        public string FirstName  { get; set; }
        public string LastName  { get; set; }
    }

}
