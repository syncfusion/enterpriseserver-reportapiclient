namespace Syncfusion.Report.Server.Api.Helper.V5
{
    using Syncfusion.Report.Server.Api.Helper.V5.EndPoints;
    using Syncfusion.Report.Server.API.Helper;

    public sealed class ServerClientV5 : ServerApiHelper
    {
        public ServerClientV5()
        {
            BaseUrl = BaseUrl + "/api/v5.0";
        }

        public ItemsEndPoint ItemsEndPoint()
        {
            return new ItemsEndPoint(this);
        }
    }
}
