using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Services;
using WebMvc.ViewModels;

namespace WebMvc.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ICatalogService _service;

        public CatalogController(ICatalogService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index(int? page, int? typesFilterApplied, int? categoryFilterApplied, 
            int? subcategoryFilterApplied)
        {
            var itemsOnPage = 10;

            var catalog = await _service.GetCatalogItemsAsync(page ?? 0, itemsOnPage, typesFilterApplied,
                categoryFilterApplied, subcategoryFilterApplied);
            var ActualItemsOnPage = Math.Min((int)(catalog.Count - ((page ?? 0) * itemsOnPage)), itemsOnPage);

            var vm = new CatalogIndexViewModel
            {
                EventItems = catalog.Data,
                Types = await _service.GetTypesAsync(),
                Category = await _service.GetCategoriesAsync(),
                SubCategory = await _service.GetSubCategoriesAsync(),
                PaginationInfo = new PaginationInfo
                {
                    ActualPage = page ?? 0,
                    //ItemsPerPage = itemsOnPage,
                    ItemsPerPage = ActualItemsOnPage,
                    TotalItems = catalog.Count,
                    TotalPages = (int)Math.Ceiling((decimal)catalog.Count / itemsOnPage)
                },
                TypesFilterApplied = typesFilterApplied ?? 0,
                CategoryFilterApplied = categoryFilterApplied ?? 0,
                SubCategoryFilterApplied = subcategoryFilterApplied ?? 0
            };

            return View(vm);
        }

        [Authorize]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";


            return View();
        }


    }
}
