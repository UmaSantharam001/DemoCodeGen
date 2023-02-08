using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class Broker
    {
        public int Id  { get; set; }
        public string FirstName  { get; set; }
        public string LastName  { get; set; }
        public string Name  { get; set; }
        public string DateOfBirth  { get; set; }
        public string MailAddress1  { get; set; }
        public string WritingCode  { get; set; }
        public string NPN  { get; set; }
        public string SSN  { get; set; }
        public string AgentSuspended  { get; set; }
        public string LicenseStatus  { get; set; }
        public DateTime LicenseExpirationDate  { get; set; }
        public int Status  { get; set; }
        public string LicenseState  { get; set; }
        public string Relationship  { get; set; }
        public string Phone  { get; set; }
        public string Email  { get; set; }
    }

}
