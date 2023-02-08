using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using Estimate.BusinessEntities;

namespace Estimate.Test.Business.MemberServiceSpec
{
    public class When_getting_all_Member : UsingMemberServiceSpec
    {
        private IEnumerable<Letter> _result;
        private string _nameId = "dscdfc";
        private int channelId = 0;
        private IEnumerable<Letter> _all_Letters;
        private Letter _letter;
        private ApiResponse _apiResponse;

        public override void Context()
        {
            base.Context();

            _letter = new Letter
            {
                toDoId = "dscdfc",
                templateName = "dsffd",
                templateType = "dffd",
                dateCompleted = "dsf",
                dateScheduled = "sdfs",
                letterName = "sdff",
                resultPrimary = "sdf",
                resultSecondary = "fsf"
            };
            _apiResponse = new ApiResponse
            {
                data = new ApiResponseData { letters = new Letter[] { _letter } },
                errors = new Error[] { },
                MpStatusCode = 0
            };

            _all_Letters = new List<Letter> { _letter };
            baseGateway.GetData<ApiResponse, ApiResponse>($"http://localhost:3000/members/{_nameId}").Returns(_apiResponse);
            _correspondenceloggetbynameidRepository.CorrespondenceLogGetByNameIdByNameId_GET_Data("dscdfc", "", "", channelId).Returns(_all_Letters);
        }
        public override void Because()
        {
            _result = subject.Member_GetMemberById_BL(_nameId, channelId);
        }

        [Test]
        public void Request_is_routed_through_repository()
        {
            _correspondenceloggetbynameidRepository.Received(1).CorrespondenceLogGetByNameIdByNameId_GET_Data("dscdfc", "", "", channelId).Returns(_all_Letters);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.ShouldBeOfType<List<Letter>>();

            List<Letter> resultList = _result as List<Letter>;

            resultList.Count.ShouldBe(1);

            resultList.ShouldBe(_all_Letters);
        }
    }
}
