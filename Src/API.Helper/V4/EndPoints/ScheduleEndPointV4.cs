namespace Syncfusion.Report.Server.Api.Helper.V4.EndPoints
{
    using System;
    using Newtonsoft.Json;
    using Syncfusion.Report.Server.Api.Helper.V3.Models;
    using Syncfusion.Report.Server.Api.Helper.V4.Models;

    public class ScheduleEndPointV4
    {
        private readonly ServerClientV4 _serverClientV4;
        private readonly string _baseUrl;

        public ScheduleEndPointV4(ServerClientV4 serverClientV4)
        {
            _serverClientV4 = serverClientV4;
            _baseUrl = _serverClientV4.BaseUrl;
        }

        /// <summary>
        /// This method is used to create new schedules.
        /// </summary>        
        /// <param name="apiScheduleRequest">Schedule details.</param>
        /// <returns>Status of adding schedule in server.</returns>

        public ApiScheduleResponse AddSchedule(ApiScheduleRequestV4 apiScheduleRequest)
        {
            var result = _serverClientV4.Post(apiScheduleRequest, _baseUrl + "/reports/schedule");
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

        public ApiScheduleResponse UpdateSchedule(Guid scheduleid, ApiUpdateScheduleRequestV4 apiScheduleRequest)
        {
            var result = _serverClientV4.Put(apiScheduleRequest, _baseUrl + "/reports/schedule/" + scheduleid);
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
        /// This method returns item details for the values Schedule Id.
        /// </summary>
        /// <param name="scheduleId">The id values should be valid Schedule Id.</param>
        /// <returns>Item details for the values.</returns>

        public ApiScheduleItemDetail GetScheduleDetail(Guid scheduleId)
        {
            var overrideUrl = _baseUrl + "/reports/schedule/" + scheduleId;
            var scheduleDetail = new ApiScheduleItemDetail();
            var result = _serverClientV4.Get(scheduleDetail, overrideUrl);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiScheduleItemDetail>(result.Content);
            }
            else
            {
                return scheduleDetail;
            }
        }

        /// <summary>
        /// This method returns report parameter details
        /// </summary>
        /// <param name="repotId">The id values should be valid report Id.</param>
        /// <returns>Parameter details for the values.</returns>

        public ApiReportParameters GetReportParameters(Guid repotId)
        {
            var overrideUrl = _baseUrl + "/reports/parameters/" + repotId;
            var reportParameters = new ApiReportParameters();
            var result = _serverClientV4.Get(reportParameters, overrideUrl);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiReportParameters>(result.Content);
            }
            else
            {
                return reportParameters;
            }
        }
    }
}
