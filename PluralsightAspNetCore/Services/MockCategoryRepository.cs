using PluralsightAspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluralsightAspNetCore.Services
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category { CategoryId=1, CategoryName="Fruit pies", Description="Fruit pies" },
                new Category { CategoryId=2, CategoryName="Fruit pies 1", Description="Fruit pies" },
                new Category { CategoryId=3, CategoryName="Fruit pies 2", Description="Fruit pies" },
            };
    }
}
