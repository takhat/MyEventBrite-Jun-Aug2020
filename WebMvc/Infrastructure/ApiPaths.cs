using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Infrastructure
{
    public class ApiPaths
    {

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

      /*      public static string GetAllEventLocations(string baseUri)
            {
                return $"{baseUri}eventlocations";
            }

            public static string GetAllEventDatesAndTimes(string baseUri)
            {
                return $"{baseUri}eventdatesandtimes";
            }       */

            public static string GetAllCatalogItems(string baseUri, int page, int take,
                                              int? type, int? category, int? subCategory)
            {
                var filterQs = string.Empty;
                if (type.HasValue || category.HasValue || subCategory.HasValue)
                {
                    var typeQs = (type.HasValue) ? type.Value.ToString() : " ";
                    var categoryQs = (category.HasValue) ? category.Value.ToString() : " ";
                    var subCategoryQs = (subCategory.HasValue) ? subCategory.Value.ToString() : " ";
                    filterQs = $"/type/{typeQs}/category/{categoryQs}/subCategory/{subCategoryQs}";
                }
                return $"{baseUri}eventitems{filterQs}?pageIndex={page}&pageSize={take}";
            }   

        }
    }
}
