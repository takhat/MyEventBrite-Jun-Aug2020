using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Infrastructure
{
    public class ApiPaths
    {
        public static class Order
        {
            public static string GetOrder(string baseUri, string orderId)
            {
                return $"{baseUri}/{orderId}";
            }

            //public static string GetOrdersByUser(string baseUri, string userName)
            //{
            //    return $"{baseUri}/userOrders?userName={userName}";
            //}
            public static string GetOrders(string baseUri)
            {
                return baseUri;
            }
            public static string AddNewOrder(string baseUri)
            {
                return $"{baseUri}/new";
            }
        }
        public static class Basket
        {
            public static string GetBasket(string baseUri, string basketId)
            {
                return $"{baseUri}/{basketId}";
            }

            public static string UpdateBasket(string baseUri)
            {
                return baseUri;
            }

            public static string CleanBasket(string baseUri, string basketId)
            {
                return $"{baseUri}/{basketId}";
            }
        }

        public static class Catalog
        {
            public static string GetAllTypes(string baseUri)
            {
                return $"{baseUri}eventtypes";
            }

            public static string GetAllCategories(string baseUri)
            {
                return $"{baseUri}eventcategories";
            }

            public static string GetAllSubCategories(string baseUri)
            {
                return $"{baseUri}eventsubcategories";
            }

            public static string GetAllEventZipCodes(string baseUri)
            {
                return $"{baseUri}eventzipcodes";
            }

            /*public static string GetAllEventDatesAndTimes(string baseUri)
            {
                return $"{baseUri}eventdatesandtimes";
            }       */

            public static string GetAllCatalogItems(string baseUri, int page, int take,
                                              int? zipcode, int? type, int? category, int? subCategory)
            {
                var filterQs = string.Empty;
                if (zipcode.HasValue || type.HasValue || category.HasValue || subCategory.HasValue)
                {
                    var zipcodeQs = (zipcode.HasValue) ? zipcode.Value.ToString() : "";
                    var typeQs = (type.HasValue) ? type.Value.ToString() : " ";
                    var categoryQs = (category.HasValue) ? category.Value.ToString() : " ";
                    var subCategoryQs = (subCategory.HasValue) ? subCategory.Value.ToString() : " ";
                    filterQs = $"/zipcode/{zipcodeQs}/type/{typeQs}/category/{categoryQs}/subCategory/{subCategoryQs}";
                }
                return $"{baseUri}eventitems{filterQs}?pageIndex={page}&pageSize={take}";
            }   

        }
    }
}
