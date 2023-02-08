using System.Data;

namespace Estimate.Data.Interfaces
{
    public interface IGateway
    {
        IDbConnection CreateConnection();
    }
}
