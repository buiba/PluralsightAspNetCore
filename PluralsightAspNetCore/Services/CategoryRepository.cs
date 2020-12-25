using PluralsightAspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluralsightAspNetCore.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDBContext _appDBContext;
        public CategoryRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public IEnumerable<Category> AllCategories => _appDBContext.Categories;
    }
}
