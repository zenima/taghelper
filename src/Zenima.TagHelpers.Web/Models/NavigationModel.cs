using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zenima.TagHelpers.Web.Models
{
    public class NavigationModel
    {
        public List<NavigationItem> Items { get; set; } = new List<NavigationItem>();
    }

    public class NavigationItem
    {
        public string Page { get; set; }

        public string Title { get; set; }

        public bool IsActive { get; set; }
    }
}
