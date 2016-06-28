using System.Collections.Generic;
using System.Linq;
using Angkor.O7Common.Entities;

namespace Angkor.O7Common.Data.Utility
{
    public static class EntityExtension
    {
        public static bool ExistsCompanyId(this List<Company> element, string id) => element.Any(company => company.Id == id);
    }
}