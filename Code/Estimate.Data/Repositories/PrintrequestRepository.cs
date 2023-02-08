using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using Estimate.BusinessEntities;

using Estimate.Data.Constants;
using Estimate.Data.Context;
using Estimate.Data.Interfaces;
using Estimate.Data.Repositories.Interfaces;


namespace Estimate.Data.Repositories
{
    public class PrintrequestRepository : IPrintrequestRepository
    {
        private readonly DataContext _dataContext;

        public PrintrequestRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public PrintRequestresponse PrintRequestInsert_Data (PrintRequestresponse body, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<PrintRequestresponse>('dbo.PrintRequestInsert', RequestID, TypeID, PlanID, NameID, MemberID, MedicareID, Prefix, FirstName, MI, LastName, Address1, Address2, City, State, ZipCode, Phonenumber, GroupID, PBP, DoNotCall, Language, RequestLocation, RequestMethodID, CreatedBy, Notes, DistributionMethod, EmailAddress);
            return null;
        }

    }
}
