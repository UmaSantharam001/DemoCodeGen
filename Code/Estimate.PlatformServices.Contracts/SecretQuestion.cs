using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class SecretQuestion
    {
        public int SecretQuestionId  { get; set; }
        public string SecretQuestionText  { get; set; }
        public DateTime EffectiveDate  { get; set; }
        public DateTime HiddenDate  { get; set; }
    }

}
