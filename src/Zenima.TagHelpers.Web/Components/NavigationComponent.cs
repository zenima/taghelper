using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zenima.TagHelpers.Web.Models;

namespace Zenima.TagHelpers.Web.Components
{
    [ViewComponent(Name = "Navigation")]
    public class NavigationComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var pageNames = new List<(string name, string title)>
            {
                ("DisplayTagHelper", "Display"),
                ("WrapperTagHelper", "Display Wrapper")
            };
            string currentPage = null;
            if (Request.RouteValues.TryGetValue("page", out var value))
                currentPage = value.ToString().TrimStart('/');

            var model = new NavigationModel();
            foreach (var page in pageNames)
            {
                var item = new NavigationItem {
                    Page = page.name,
                    Title = page.title
                };

                if (string.Equals(page.name, currentPage, StringComparison.OrdinalIgnoreCase))
                    item.IsActive = true;
                
                model.Items.Add(item);
            }

            return View(model);
        }
    }
}
