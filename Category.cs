using System.Collections.Generic;

namespace RepositoryPattern.BasicExample
{
    public class Category : EntityBase
    {
        public int ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int ParentID
        {
            get;
            set;
        }

        public List<Category> SubCategories
        {
            get;
            set;
        }
    }
}