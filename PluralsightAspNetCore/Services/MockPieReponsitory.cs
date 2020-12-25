using PluralsightAspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluralsightAspNetCore.Services
{
    public class MockPieReponsitory : IPieReponsitory
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> Pies =>
            new List<Pie>
            { 
                new Pie { PieId = 1, Name = "Strawberry Pie", Category = new Category{ CategoryId = 1, CategoryName = "Test"}, Price = 15.95M, ShortDescription = "Strawberry Pie", LongDescription = "Strawberry Pie Long"},
                new Pie { PieId = 2, Name = "Strawberry Pie", Category = new Category{ CategoryId = 1, CategoryName = "Test"}, Price = 15.95M, ShortDescription = "Strawberry Pie", LongDescription = "Strawberry Pie Long"},
                new Pie { PieId = 3, Name = "Strawberry Pie", Category = new Category{ CategoryId = 1, CategoryName = "Test"}, Price = 15.95M, ShortDescription = "Strawberry Pie", LongDescription = "Strawberry Pie Long"},
                new Pie { PieId = 4, Name = "Strawberry Pie", Category = new Category{ CategoryId = 1, CategoryName = "Test"}, Price = 15.95M, ShortDescription = "Strawberry Pie", LongDescription = "Strawberry Pie Long"}
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
