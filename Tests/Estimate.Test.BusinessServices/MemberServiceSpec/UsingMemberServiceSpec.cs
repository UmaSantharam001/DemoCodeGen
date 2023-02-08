using NSubstitute;
using Estimate.Test.Framework;
using Estimate.BusinessServices.Interfaces;
using Estimate.Data.Repositories.Interfaces;
using Estimate.BusinessServices;
using Estimate.ServiceGateway;

namespace Estimate.Test.Business.MemberServiceSpec
{
    public abstract class UsingMemberServiceSpec : SpecFor<MemberService>
    {
        protected ICorrespondenceloggetbynameidRepository _correspondenceloggetbynameidRepository;
        protected BaseGateway baseGateway;

        public override void Context()
        {
            _correspondenceloggetbynameidRepository = Substitute.For<ICorrespondenceloggetbynameidRepository>();
            baseGateway = Substitute.For<BaseGateway>();
            subject = new MemberService(baseGateway, _correspondenceloggetbynameidRepository);

        }

    }
}
