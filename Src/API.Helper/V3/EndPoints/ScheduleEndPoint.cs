using Newtonsoft.Json;
using Syncfusion.Report.Server.Api.Helper.V3.Models;
using Syncfusion.Report.Server.API.Helper.V3;
using System;

namespace Syncfusion.Report.Server.Api.Helper.V3.EndPoints
{
    public class ScheduleEndPoint
    {
        private readonly ServerClientV3 _serverClientV3;
        private readonly string _baseUrl;

        public ScheduleEndPoint(ServerClientV3 serverClientV3)
        {
            _serverClientV3 = serverClientV3;
            _baseUrl = _serverClientV3.BaseUrl;
        }

        /// <summary>
        /// This method is used to create new schedules.
        /// </summary>        
        /// <param name="apiScheduleRequest">Schedule details.</param>
        /// <returns>Status of adding schedule in server.</returns>

        public ApiScheduleResponse AddSchedule(ApiScheduleRequest apiScheduleRequest)
        {
            var result = _serverClientV3.Post(apiScheduleRequest, _baseUrl + "/reports/schedule");
            var response = new ApiScheduleResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiScheduleResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }

        /// <summary>
        /// This method is used to create new schedules.
        /// </summary>    
        /// <param name="scheduleid">Schedule Id </param>
        /// <param name="apiScheduleRequest">Schedule details.</param>
        /// <returns>Status of adding schedule in server.</returns>

        public ApiScheduleResponse UpdateSchedule(Guid scheduleid, ApiScheduleRequest apiScheduleRequest)
        {
            var result = _serverClientV3.Put(apiScheduleRequest, _baseUrl + "/reports/schedule/" + scheduleid);
            var response = new ApiScheduleResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiScheduleResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }
    }
}
