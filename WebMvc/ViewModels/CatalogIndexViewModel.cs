using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;

namespace WebMvc.ViewModels
{
    public class CatalogIndexViewModel
    {
        public IEnumerable<SelectListItem> ZipCode { get; set; }
        public IEnumerable<SelectListItem> Types { get; set; }

        public IEnumerable<SelectListItem> Category { get; set; }

        public IEnumerable<SelectListItem> SubCategory { get; set; }

        public IEnumerable<EventItem> EventItems { get; set; }

        public PaginationInfo PaginationInfo { get; set; }
        public int? ZipCodeFilterApplied { get; set; }

        public int? TypesFilterApplied { get; set; }

        public int? CategoryFilterApplied { get; set; }

        public int? SubCategoryFilterApplied { get; set; }

    }
}
