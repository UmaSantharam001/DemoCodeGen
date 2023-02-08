using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using Microsoft.AspNetCore.Mvc;
using Estimate.BusinessEntities;
using Estimate.PlatformServices.Contracts;
using Estimate.Test.Api.MemberControllerSpec;

namespace Estimate.Test.Api.EmployeeControllerSpec
{
    public class When_getting_all_letter : UsingMemberControllerSpec
    {
        private ActionResult<IEnumerable<PlatformServices.Contracts.Letter>> _result;

        private IEnumerable<BusinessEntities.Letter> _all_letters;
        private BusinessEntities.Letter _letterBusiness;
        private PlatformServices.Contracts.Letter _letterContracts;
        private string _nameId = "sfdc";
        private int channelId = 0;

        public override void Context()
        {
            base.Context();

            var letterData = new PlatformServices.Contracts.Letter
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
            _letterContracts = letterData;

            var lettercontractsMock = new BusinessEntities.Letter
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
            _letterBusiness = lettercontractsMock;



            _all_letters = new List<BusinessEntities.Letter> { _letterBusiness};
            _memberService.Member_GetMemberById_BL(_nameId, channelId).Returns(_all_letters);
        }
        public override void Because()
        {
            _result = subject.Member_GetMemberById1(_nameId, channelId);
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _memberService.Received(1).Member_GetMemberById_BL(_nameId, channelId);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<List<BusinessEntities.Letter>>();

            List<BusinessEntities.Letter> resultList = resultListObject as List<BusinessEntities.Letter>;

            resultList.Count.ShouldBe(1);
            resultList.ShouldBe(_all_letters);

            

        }
    }
}
