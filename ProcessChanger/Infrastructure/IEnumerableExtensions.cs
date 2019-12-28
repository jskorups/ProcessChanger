using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProcessChanger.Infrastructure
{
    public static class IEnumerableExtensions
    {
        public static IList<SelectListItem> ToSelectListItem<T>(this IEnumerable<T> items, Func<T, SelectListItem> convert)
        {
            return items.Select(convert).ToList();
        }
    }
}