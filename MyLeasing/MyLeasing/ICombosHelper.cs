using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyLeasing.Web.Data.Entities;

namespace MyLeasing
{
    internal interface ICombosHelper
    {
        object ToPropertyViewModel(Property property);
        IEnumerable<SelectListItem> GetComboPropertyTypes();
    }
}