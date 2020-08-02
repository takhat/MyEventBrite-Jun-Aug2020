using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.ViewModels
{
    public class EventItemViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }

        public int EventTypeId { get; set; }
        public int EventCategoryId { get; set; }
        public int EventSubCategoryId { get; set; } 

        public string EventType { get; set; }
        public string EventCategory { get; set; }
        public string EventSubCategory { get; set; }
        public string Location { get; set; }
        public string StartDateTime { get; set; }
        public string EndDateTime { get; set; }

        public int DateAndTimeId { get; set; }
        public int LocationId { get; set; }     

        public int Price { get; set;}
        public string Contact { get; set; } 

    }
}
