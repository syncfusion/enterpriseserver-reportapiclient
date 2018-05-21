using Syncfusion.Report.Server.Api.Helper.V3.EndPoints;

namespace Syncfusion.Report.Server.API.Helper.V3
{
    public sealed class ServerClientV3 : ServerApiHelper
    {
        public ServerClientV3()
        {
            BaseUrl = BaseUrl + "/api/v3.0";
        }

        public ScheduleEndPoint ScheduleEndPoint3()
        {
            return new ScheduleEndPoint(this);
        }

    }
}