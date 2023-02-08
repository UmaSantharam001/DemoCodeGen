using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class Secretquestionresponse
    {
        public int UserId  { get; set; }
        public int SecretQuestionId  { get; set; }
        public string Answer  { get; set; }
    }
}
