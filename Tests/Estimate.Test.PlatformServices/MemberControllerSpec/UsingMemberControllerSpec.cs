using NSubstitute;
using Estimate.Test.Framework;
using Estimate.PlatformServices.Controllers;
using Estimate.BusinessServices.Interfaces;


namespace Estimate.Test.Api.MemberControllerSpec
{
    public abstract class UsingMemberControllerSpec : SpecFor<MemberController>
    {
        protected IMemberService _memberService;

        public override void Context()
        {
            _memberService = Substitute.For<IMemberService>();
            subject = new MemberController(_memberService);

        }

    }
}
