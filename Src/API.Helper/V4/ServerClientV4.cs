using Syncfusion.Report.Server.Api.Helper.V4.EndPoints;
using Syncfusion.Report.Server.API.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncfusion.Report.Server.Api.Helper.V4
{
    public sealed class ServerClientV4 : ServerApiHelper
    {
        public ServerClientV4()
        {
            BaseUrl = BaseUrl + "/api/v4.0";
        }

        public ScheduleEndPointV4 ScheduleEndPoint4()
        {
            return new ScheduleEndPointV4(this);
        }

    }
}
