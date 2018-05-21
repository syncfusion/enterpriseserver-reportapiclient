using Newtonsoft.Json;
using Syncfusion.Report.Server.Api.Helper.Authentication;
using Syncfusion.Report.Server.Api.Helper.V2.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Syncfusion.Report.Server.API.Helper.V2.EndPoints
{
    public class ItemsEndPoint
    {
        private readonly ServerClientV2 _serverClientV2;
        private readonly string _baseUrl;

        public ItemsEndPoint(ServerClientV2 serverClientV2)
        {
            _serverClientV2 = serverClientV2;
            _baseUrl = _serverClientV2.BaseUrl;
        }        

        /// <summary>
        /// This method is used to add new category to the server.
        /// </summary>
        /// <param name="apiCategoryAdd">Category details (Category name and category description) to be added.</param>
        /// <returns>Status of adding category to the server.</returns>
        public ApiResponse AddCategory(ApiCategoryAdd apiCategoryAdd)
        {
            var result = _serverClientV2.Post(apiCategoryAdd, _baseUrl + "/categories");
            var response = new ApiResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiResponse>(result.Content);
            }
            else
            {
                return new ApiResponse();
            }
        }

        /// <summary>
        /// This method is used to update the existing category on the server.
        /// </summary>
        /// <param name="apiCategoryUpdate">Category details (Category name and category description) to be updated.</param>
        /// <returns>Status of updating the category on the server.</returns>

        public ApiResponse UpdateCategory(ApiCategoryUpdate apiCategoryUpdate)
        {
            var requestUrl = _baseUrl + "/categories";
            var result = _serverClientV2.Put(apiCategoryUpdate, requestUrl);
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
        /// This method is used to add new report to the server.
        /// </summary>
        /// <param name="apiReportAdd">Report details (Report name, Report description, IsPublic, Item in an array of bytes) to be added.</param>
        /// <returns>Status of added report to the server.</returns>

        public ApiItemResponse AddReport(ApiReportAdd apiReportAdd)
        {
            var result = _serverClientV2.Post(apiReportAdd, _baseUrl + "/reports");
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

        public ApiItemResponse UpdateReport(ApiReportUpdate apiReportUpdate)
        {
            var requestUrl = _baseUrl + "/reports";
            var result = _serverClientV2.Put(apiReportUpdate, requestUrl);
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
        /// This method is used to add new datasource to the server.
        /// </summary>
        /// <param name="apiDataSourceAdd">Datasource details(Datasource name, Datasource description and item in an array of bytes) to be added.</param>
        /// <returns>Status of adding datasource to the server.</returns>

        public ApiItemResponse AddDataSource(ApiReportDataSourceAdd apiReportDataSourceAdd)
        {
            var result = _serverClientV2.Post(apiReportDataSourceAdd, _baseUrl + "/reports/data-sources");
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

        public ApiResponse UpdateDataSource(ApiReportDataSourceUpdate apiReportDataSourceUpdate)
        {
            var requestUrl = _baseUrl + "/reports/data-sources";
            var result = _serverClientV2.Put(apiReportDataSourceUpdate, requestUrl);
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
        ///  This method is used to add new widget to the server.
        /// </summary>
        /// <param name="apiWidgetAdd">Widget details(Widget name, widget description, IsPublic, items in an array of bytes) to be added.</param>
        /// <returns>Status of adding widget to the server.</returns>

        public ApiItemResponse AddDataset(ApiReportDataSetAdd apiReportDatasetAdd)
        {
            var result = _serverClientV2.Post(apiReportDatasetAdd, _baseUrl + "/reports/datasets");
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
        /// This method is used to update the existing widget on the server.
        /// </summary>
        /// <param name="apiWidgetUpdate">Widegt details (Widget name, widget description, IsPublic, items in an array of bytes) to be updated.</param>
        /// <returns>Status of updating the widget on the server.</returns>

        public ApiItemResponse UpdateDataset(ApiReportDataSetUpdate apiReportDatasetUpdate)
        {
            var requestUrl = _baseUrl + "/reports/datasets";
            var result = _serverClientV2.Put(apiReportDatasetUpdate, requestUrl);
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
        ///  This method is used to add new file to the server.
        /// </summary>
        /// <param name="apiFileAdd">File details(File name, File description, File extension, items in an array of bytes) to be added.</param>
        /// <returns>Status of adding file to the server.</returns>

        public ApiItemResponse AddFile(ApiFileAdd apiFileAdd)
        {
            var result = _serverClientV2.Post(apiFileAdd, _baseUrl + "/reports/files");
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
        /// This method is used to update the existing file on the server.
        /// </summary>
        /// <param name="apiFileUpdate">File details (file name, file description, file extension, items in an array of bytes) to be updated.</param>
        /// <returns>Status of updating the file on the server.</returns>

        public ApiItemResponse UpdateFile(ApiFileUpdate apiFileUpdate)
        {
            var requestUrl = _baseUrl + "/reports/files";
            var result = _serverClientV2.Put(apiFileUpdate, requestUrl);
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
        /// This method is used to export the reports for the users who have read access for reports.
        /// </summary>
        /// <param name="apiExportReport">Report details (Report Id, Server path, Export type).</param>
        /// <returns>Status of exporting the report.</returns>

        public ApiExportReportResponse ExportReport(ApiExportReport apiExportReport)
        {
            var result = _serverClientV2.Post(apiExportReport, _baseUrl + "/reports/export");
            var response = new ApiExportReportResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiExportReportResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }


        /// <summary>
        /// This method is used to delete the item(Category, Report, Datasource, Dataset, File, Schedule) on the server.
        /// </summary>
        /// <param name="id">Item Id.</param>
        /// <returns>Status of deleting the items on the server.</returns>

        public ApiResponse DeleteItem(Guid id)
        {
            var requestUrl = _baseUrl + "/items/" + id;
            var result = _serverClientV2.Delete(new ApiItems(), requestUrl);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiResponse>(result.Content);
            }
            else
            {
                return new ApiResponse
                {
                    ApiStatus = true,
                    StatusMessage = "Item has been deleted successfully."
                };
            }
        }

        /// <summary>
        /// This method returns item details for the values Category Id, Report Id, Datasource Id, Dataset Id, File Id and Schedule Id.
        /// </summary>
        /// <param name="id">The id values may be Category Id, Report Id, Datasource Id, Dataset Id, File Id and Schedule Id.</param>
        /// <returns>Item details for the values.</returns>

        public ApiSpecifiedItemDetail GetItemDetail(Guid id)
        {
            var overrideUrl = _baseUrl + "/items/" + id;
            var itemDetail = new ApiSpecifiedItemDetail();
            var result = _serverClientV2.Get(itemDetail, overrideUrl);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiSpecifiedItemDetail>(result.Content);
            }
            else
            {
                return itemDetail;
            }
        }

        /// <summary>
        /// This method returns list of items for the itemtype category, report, datasource, dataset, file and schedule.
        /// </summary>
        /// <param name="itemType">Item type (category, report, datasource, dataset, file and schedule)</param>
        /// <param name="serverPath">Category path</param>
        /// <returns>List of items for the itemtype.</returns>

        public List<ApiItems> GetItems([FromUri] ItemType itemType, [FromUri] string serverPath = null)
        {
            var requestUrl = _baseUrl + "/items";
            var items = new List<ApiItems>();
            var param = new Dictionary<string, object>();
            param.Add("itemtype", itemType);
            var result = _serverClientV2.Get(items, requestUrl, param);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<List<ApiItems>>(result.Content);
            }
            else
            {
                return items;
            }
        }


        /// <summary>
        /// This method returns whether the item (category, report, datasource, dataset, file) already exists in the server.
        /// </summary>
        /// <param name="apiValidateItemName">Details about the item (Item name, category name, itemtype)</param>
        /// <returns>Returns whether the item already exists in the server.</returns>

        public bool IsItemNameExists(ApiValidateItemName apiValidateItemName)
        {
            var requestUrl = _baseUrl + "/items/is-name-exists";
            var param = new Dictionary<string, object>();
            param.Add("itemname", apiValidateItemName.ItemName);
            param.Add("itemtype", apiValidateItemName.ItemType);
            param.Add("categoryname", apiValidateItemName.CategoryName);
            var result = _serverClientV2.Post(apiValidateItemName, requestUrl, param);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<bool>(result.Content);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method returns the public items for the values report.
        /// </summary>
        /// <param name="itemType"></param>
        /// <returns>Public items for the values reports.</returns>

        public List<ApiReportPublicItems> GetPublicItems([FromUri] ItemType itemType)
        {
            var requestUrl = _baseUrl + "/reports/public";
            var publicItems = new List<ApiReportPublicItems>();
            var param = new Dictionary<string, object>();
            param.Add("itemtype", itemType);
            var result = _serverClientV2.Get(publicItems, requestUrl, param);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<List<ApiReportPublicItems>>(result.Content);
            }
            else
            {
                return publicItems;
            }
        }

        /// <summary>
        ///  This method returns list of favorite reports that belong to current user.
        /// </summary>
        /// <returns>List of favorite reports.</returns>

        public List<ApiReportFavoriteItems> GetFavoriteItems()
        {
            var requestUrl = _baseUrl + "/reports/favorite";
            var favoriteItems = new List<ApiReportFavoriteItems>();
            var result = _serverClientV2.Get(favoriteItems, requestUrl);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<List<ApiReportFavoriteItems>>(result.Content);
            }
            else
            {
                return favoriteItems;
            }
        }

        /// <summary>
        ///  This method is used to update the report as favorite or non-favorite on the server.
        /// </summary>
        /// <param name="apiUpdateFavorite">Report details (Report Id and Favorite value to set the item as favorite) to be updated.</param>
        /// <returns>Status of updating the report as favorite or non-favorite on the server.</returns>

        public ApiResponse UpdateFavoriteItem(ApiUpdateFavoriteReport apiUpdateFavorite)
        {
            var requestUrl = _baseUrl + "/reports/favorite";
            var result = _serverClientV2.Put(apiUpdateFavorite, requestUrl);
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
    }
}