namespace Syncfusion.Report.Server.Api.Helper.V5.EndPoints
{
    using System.Collections.Generic;
    using System.Web.Http;
    using Newtonsoft.Json;
    using Syncfusion.Report.Server.Api.Helper.V2.Models;
    using Syncfusion.Report.Server.Api.Helper.V5.Models;

    public class ItemsEndPoint
    {
        private readonly ServerClientV5 _serverClientV5;
        private readonly string _baseUrl;

        public ItemsEndPoint(ServerClientV5 serverClientV5)
        {
            _serverClientV5 = serverClientV5;
            _baseUrl = _serverClientV5.BaseUrl;
        }

        /// <summary>
        /// This method is used to add new report to the server.
        /// </summary>
        /// <param name="apiReportAdd">Report details (Report name, Report description, IsPublic, Item in an array of bytes) to be added.</param>
        /// <returns>Status of added report to the server.</returns>

        public ApiItemResponse AddReport(ApiReportAddV5 apiReportAdd)
        {
            var result = _serverClientV5.Post(apiReportAdd, _baseUrl + "/reports");
            var response = new ApiItemResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiItemResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }

        /// <summary>
        /// This method is used to update the existing report on the server.
        /// </summary>
        /// <param name="apiReportUpdate">Report details (Report name, Report description, IsPublic, Item in an array of bytes) to be updated.</param>
        /// <returns>Status of updating the report on the server.</returns>

        public ApiItemResponse UpdateReport(ApiReportUpdateV5 apiReportUpdate)
        {
            var requestUrl = _baseUrl + "/reports";
            var result = _serverClientV5.Put(apiReportUpdate, requestUrl);
            var response = new ApiItemResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiItemResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }

        /// <summary>
        /// This method is used to update the existing datasource on the server.
        /// </summary>
        /// <param name="apiDataSourceUpdate">Datasource details(Datasource name, Datasource description and item in an array of bytes) to be updated.</param>
        /// <returns>Status of updating the datasource on the server.</returns>

        public ApiResponse UpdateDataSource(ApiReportDataSourceUpdateV5 apiReportDataSourceUpdate)
        {
            var requestUrl = _baseUrl + "/reports/data-sources";
            var result = _serverClientV5.Put(apiReportDataSourceUpdate, requestUrl);
            var response = new ApiResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }

        /// <summary>
        ///  This method is used to add new dataset to the server.
        /// </summary>
        /// <param name="apiReportDatasetAdd">Dataset details(Dataset name, Datasource Details and item in an array of bytes) to be added.</param>
        /// <returns>Status of adding dataset to the server.</returns>

        public ApiItemResponse AddDataset(ApiReportDataSetAddV5 apiReportDatasetAdd)
        {
            var result = _serverClientV5.Post(apiReportDatasetAdd, _baseUrl + "/reports/datasets");
            var response = new ApiItemResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiItemResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }

        /// <summary>
        /// This method is used to update the existing dataset on the server.
        /// </summary>
        /// <param name="apiWidgetUpdate">Dataset details(Dataset name, Datasource Details and item in an array of bytes) to be updated.</param>
        /// <returns>Status of updating the dataset on the server.</returns>

        public ApiItemResponse UpdateDataset(ApiReportDataSetUpdateV5 apiReportDatasetUpdate)
        {
            var requestUrl = _baseUrl + "/reports/datasets";
            var result = _serverClientV5.Put(apiReportDatasetUpdate, requestUrl);
            var response = new ApiItemResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiItemResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }

        /// <summary>
        /// This method returns list of items for the itemtype category, report, datasource, dataset, file and schedule with webdesignercompatible property.
        /// </summary>
        /// <param name="itemType">Item type (category, report, datasource, dataset, file and schedule)</param>
        /// <param name="serverPath">Category path</param>
        /// <returns>List of items for the itemtype.</returns>

        public List<ApiItemDetailV5> GetItems([FromUri] ItemType itemType, [FromUri] string serverPath = null)
        {
            var requestUrl = _baseUrl + "/items";
            var items = new List<ApiItemDetailV5>();
            var param = new Dictionary<string, object>();
            param.Add("itemtype", itemType);
            var result = _serverClientV5.Get(items, requestUrl, param);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<List<ApiItemDetailV5>>(result.Content);
            }
            else
            {
                return items;
            }
        }

    }
}
