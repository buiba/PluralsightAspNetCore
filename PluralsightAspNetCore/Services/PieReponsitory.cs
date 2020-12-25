using Microsoft.EntityFrameworkCore;
using PluralsightAspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PluralsightAspNetCore.Services
{
    public class PieReponsitory : IPieReponsitory
    {
        private readonly AppDBContext _appDbContext;
        public PieReponsitory(AppDBContext appDBContext)
        {
            _appDbContext = appDBContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _appDbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        { 
            get
            {
                return _appDbContext.Pies.Include(c => c.Category).Where(x => x.IsPieOfTheWeek);
            }
        }
        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(x => x.PieId == pieId);
        }
    }
}
