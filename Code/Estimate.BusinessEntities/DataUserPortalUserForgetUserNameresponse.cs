using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class DataUserPortalUserForgetUserNameresponse
    {
        public int UserId  { get; set; }
        public string WritingCode  { get; set; }
        public string MemberId  { get; set; }
        public string Member  { get; set; }
        public string UserName  { get; set; }
        public string Email  { get; set; }
        public string SecretImage  { get; set; }
        public string SecretImageAltText  { get; set; }
        public string LoginAttempt  { get; set; }
        public string ResetGuid  { get; set; }
        public string Url  { get; set; }
        public bool IsValidUser  { get; set; }
        public string Phone  { get; set; }
        public IEnumerable<string> SecretAnswers  { get; set; }
        public IEnumerable<string> SecretQuestions  { get; set; }
        public bool HasAcceptedEula  { get; set; }
        public string PreferedContactMethod  { get; set; }
        public string PatientId  { get; set; }
        public string NPN  { get; set; }
        public string Broker  { get; set; }
        public string FirstName  { get; set; }
        public string LastName  { get; set; }
        public string Agency  { get; set; }
    }
}
