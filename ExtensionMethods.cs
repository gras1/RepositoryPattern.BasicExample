using System.Collections.Generic;
using System.Linq;

namespace RepositoryPattern.BasicExample
{
    public static class ExtensionMethods
    {
        public static IEnumerable<Category> Flatten(this IEnumerable<Category> e)
        {
            if (e == null)
            {
                return Enumerable.Empty<Category>();
            }
            return e.SelectMany(c => c.SubCategories.Flatten()).Concat(e);
        }
    }
}
