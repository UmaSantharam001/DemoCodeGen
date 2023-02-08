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
    public class NotetypesRepository : INotetypesRepository
    {
        private readonly DataContext _dataContext;

        public NotetypesRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public Notetypesresponse Notetypes_GET_Data (string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<Notetypesresponse>('dbo.NoteTypesGet', ChannelID);
            return null;
        }

    }
}
