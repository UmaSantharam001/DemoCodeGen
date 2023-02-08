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
    public class AddresschangerequestRepository : IAddresschangerequestRepository
    {
        private readonly DataContext _dataContext;

        public AddresschangerequestRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public string AddressChangeRequestMemberIDByID_GET_Data (string ID, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.AddressChangeGetByMemberID', MemberID);
            return null;
        }

    }
}
