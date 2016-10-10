using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPattern.BasicExample
{
    public class CategoryService
    {
        private readonly IRepository<Category> _repository;

        public CategoryService(IRepository<Category> repository)
        {
            _repository = repository;
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository cannot be null");
            }
        }

        public IList<Category> GetCategories()
        {
            var rawCategories = _repository.List().ToList();

            var parents = (from c in rawCategories
                where c.ParentID == 0
                select c).ToList();

            parents.ForEach(p =>
            {
                p.SubCategories = (from subs in rawCategories
                                   where subs.ParentID == p.ID
                                   select subs).ToList();
            });

            return parents;
        }
    }
}