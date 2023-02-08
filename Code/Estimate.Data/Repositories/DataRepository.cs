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
    public class DataRepository : IDataRepository
    {
        private readonly DataContext _dataContext;

        public DataRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public string DataPlanBenefitPackage_GET_Data (string pbp, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('SELECT DISTINCT Package_ID AS PlanID FROM PBP WHERE PBP = :PBP');
            return null;
        }

        public IEnumerable<DataSepReasonresponse> DataSepReason_GET_Data (string sepReason, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<IEnumerable<DataSepReasonresponse>>('SELECT Code AS SEPReason FROM dbo.SEPReason WHERE SEPReasonID = :SEPReasonID');
            return null;
        }

        public string DataSep_GET_Data (string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.SEPReasonGetAll', );
            return null;
        }

        public string DataPaymentType_GET_Data (string paymentTypeCode, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('SELECT Description AS BillingOption FROM dbo.PaymentType WHERE PaymentType = :PaymentType');
            return null;
        }

        public IEnumerable<DataEnrollmentTyperesponse> DataEnrollmentType_GET_Data (string enrollmentType, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<IEnumerable<DataEnrollmentTyperesponse>>('SELECT Description AS Source FROM dbo.EnrollmentType WHERE EnrollmentType = :EnrollmentType');
            return null;
        }

        public IEnumerable<DataPlanYearresponse> DataPlanYear_GET_Data (string planYearCode, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<IEnumerable<DataPlanYearresponse>>('SELECT Year AS PlanYear FROM dbo.PlanYear WHERE PlanYearID = :PlanYear');
            return null;
        }

        public DataMemberresponse DataMember_GET_Data (string client_id, string client_secret, int channelid)
        {
            return null;
        }

        public DataMemberByAltNameIdresponse DataMemberByAltNameIdByAltNameId_GET_Data (string altNameId, string client_id, string client_secret, int channelid)
        {
            return null;
        }

        public string DataMemberPortaluser_POST_Data (string client_id, string client_secret, int channelid)
        {
            return null;
        }

        public DataMemberAddresschangeresponse DataMemberAddresschange_POST_Data (DataMemberAddresschangerequest body, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<DataMemberAddresschangeresponse>('dbo.MemberAddressChange', ID, MemberName, MemberID, DOB, HICN, Plan, AddressType, OldAddress1, OldAddress2, OldCity, OldState, OldZipCode, NewAddress1, NewAddress2, NewCity, NewState, NewZipCode, Notes, EffectiveDate, RequestedBy, Attestation);
            return null;
        }

        public DataMemberAddressChangeRequestresponse DataMemberAddressChangeRequest_POST_Data (string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<DataMemberAddressChangeRequestresponse>('dbo.MemberAddressChange', ID, MemberName, MemberID, DOB, HICN, Plan, AddressType, OldAddress1, OldAddress2, OldCity, OldState, OldZipCode, NewAddress1, NewAddress2, NewCity, NewState, NewZipCode, Notes, EffectiveDate, RequestedBy, Attestation);
            return null;
        }

        public string DataMemberAddressChangeRequests_GET_Data (bool complete, bool assigned, string addresstype, string requeststartdate, string requestenddate, bool pbpchange, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.AddressChangeRequestsGet', complete, assigned, addresstype, requeststartdate, requestenddate, pbpchange);
            return null;
        }

        public string DataMemberAddressChangeRequest_GET_Data (double addressChangeID, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.AddressChangeRequestGetByID', addressChangeID);
            return null;
        }

        public DataMemberDisenrollmentresponse DataMemberDisenrollment_POST_Data (DataMemberDisenrollmentresponse body, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<DataMemberDisenrollmentresponse>('dbo.DisenrollmentRequestInsert', ChannelID, AltMemberId, Prefix, FirstName, MiddleInitial, LastName, Phone, Comment, Notes, CompletionDate, RequestedDate, RequestedBy, AssignedTo, NameId, ReasonId, DisenrollmentDate);
            return null;
        }

        public string DataUserGetuser_GET_Data (string client_id, string client_secret, int channelid)
        {
            return null;
        }

        public DataUserPortalUserForgetUserNameresponse DataUserPortalUserForgetUserName_POST_Data (string client_id, string client_secret, int channelid)
        {
            return null;
        }

    }
}
