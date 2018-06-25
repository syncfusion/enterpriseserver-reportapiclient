using Syncfusion.Report.Server.API.Helper;
using Syncfusion.Report.Server.API.Helper.V1.EndPoints;

namespace Syncfusion.Report.Server.Api.Helper.V1
{
    public sealed class ServerClientV1 : ServerApiHelper
    {
        public ServerClientV1()
        {
            BaseUrl = BaseUrl + "/api/v1.0";
        }

        public UsersEndPoint UsersEndPoint()
        {
            return new UsersEndPoint(this);
        }

        public GroupsEndPoint GroupsEndPoint()
        {
            return new GroupsEndPoint(this);
        }
    }
}
