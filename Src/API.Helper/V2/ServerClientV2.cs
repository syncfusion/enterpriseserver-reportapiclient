using Syncfusion.Report.Server.API.Helper.V2.EndPoints;

namespace Syncfusion.Report.Server.API.Helper.V2
{
    public sealed class ServerClientV2 : ServerApiHelper
    {
        public ServerClientV2()
        {
           BaseUrl = BaseUrl + "/api/v2.0";
        }

        public UsersEndPoint2 UsersEndPoint2()
        {
            return new UsersEndPoint2(this);
        }

        public GroupsEndPoint2 GroupsEndPoint2()
        {
            return new GroupsEndPoint2(this);
        }

        public ItemsEndPoint ItemsEndPoint()
        {
            return new ItemsEndPoint(this);
        }

        public PermissionEndPoint PermissionsEndPoint()
        {
            return new PermissionEndPoint(this);
        }
    }
}