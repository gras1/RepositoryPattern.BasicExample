using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RepositoryPattern.BasicExample
{
    public class TestCategoryRepository : IRepository<Category>
    {
        private readonly List<Category> _sampleCategories;

        public TestCategoryRepository()
        {
            _sampleCategories = new List<Category>();

            for (var i = 1; i <= 2; i++)
            {
                var c = new Category
                {
                    ID = i,
                    Name = "Parent" + i,
                    ParentID = 0
                };

                for (var x = 10; x < 15; x++)
                {
                    var sub = new Category
                    {
                        ID = x,
                        Name = "Sub" + x,
                        ParentID = i
                    };
                    _sampleCategories.Add(sub);
                }

                _sampleCategories.Add(c);
            }
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> List()
        {
            return _sampleCategories.AsQueryable();
        }

        public IQueryable<Category> List(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
