using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IDataRepository
    {
        string DataPlanBenefitPackage_GET_Data (string pbp, string client_id, string client_secret, int channelid);

        IEnumerable<DataSepReasonresponse> DataSepReason_GET_Data (string sepReason, string client_id, string client_secret, int channelid);

        string DataSep_GET_Data (string client_id, string client_secret, int channelid);

        string DataPaymentType_GET_Data (string paymentTypeCode, string client_id, string client_secret, int channelid);

        IEnumerable<DataEnrollmentTyperesponse> DataEnrollmentType_GET_Data (string enrollmentType, string client_id, string client_secret, int channelid);

        IEnumerable<DataPlanYearresponse> DataPlanYear_GET_Data (string planYearCode, string client_id, string client_secret, int channelid);

        DataMemberresponse DataMember_GET_Data (string client_id, string client_secret, int channelid);

        DataMemberByAltNameIdresponse DataMemberByAltNameIdByAltNameId_GET_Data (string altNameId, string client_id, string client_secret, int channelid);

        string DataMemberPortaluser_POST_Data (string client_id, string client_secret, int channelid);

        DataMemberAddresschangeresponse DataMemberAddresschange_POST_Data (DataMemberAddresschangerequest body, string client_id, string client_secret, int channelid);

        DataMemberAddressChangeRequestresponse DataMemberAddressChangeRequest_POST_Data (string client_id, string client_secret, int channelid);

        string DataMemberAddressChangeRequests_GET_Data (bool complete, bool assigned, string addresstype, string requeststartdate, string requestenddate, bool pbpchange, string client_id, string client_secret, int channelid);

        string DataMemberAddressChangeRequest_GET_Data (double addressChangeID, string client_id, string client_secret, int channelid);

        DataMemberDisenrollmentresponse DataMemberDisenrollment_POST_Data (DataMemberDisenrollmentresponse body, string client_id, string client_secret, int channelid);

        string DataUserGetuser_GET_Data (string client_id, string client_secret, int channelid);

        DataUserPortalUserForgetUserNameresponse DataUserPortalUserForgetUserName_POST_Data (string client_id, string client_secret, int channelid);

    }
}
