using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class Letter
    {
        public string toDoId  { get; set; }
        public string templateType  { get; set; }
        public string templateName  { get; set; }
        public string letterName  { get; set; }
        public string dateScheduled  { get; set; }
        public string dateCompleted  { get; set; }
        public string resultPrimary  { get; set; }
        public string resultSecondary  { get; set; }

    }
}
