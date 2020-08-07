using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;

namespace WebMvc.Services
{
    public interface ICatalogService
    {
        Task<Event> GetCatalogItemsAsync(int page, int size, int? zipcode, int? type, int? category, int? subCategory);

        Task<IEnumerable<SelectListItem>> GetZipCodesAsync();
        Task<IEnumerable<SelectListItem>> GetTypesAsync();

        Task<IEnumerable<SelectListItem>> GetCategoriesAsync();

        Task<IEnumerable<SelectListItem>> GetSubCategoriesAsync();

    }
}
