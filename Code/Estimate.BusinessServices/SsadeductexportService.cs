using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class SsadeductexportService : ISsadeductexportService
    {

      private BaseGateway _gateway;

      public SsadeductexportService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public SSADeductExportresponse UserName_BL (string UserName)
      {
        //  
        return null;
      }

    }
}
