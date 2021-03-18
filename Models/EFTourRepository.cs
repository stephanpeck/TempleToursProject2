using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// EFTourRepository
namespace TempleToursProject.Models
{
    public class EFTourRepository : ITourRepository
    {
        private TourDbContext _context;

        //Constructor
        public EFTourRepository (TourDbContext context)
        {
            _context = context;
        }


        //Dbs set from TourDbContext.cs
        public IQueryable<GroupInfo> Groups => _context.GroupInfo;
        public IQueryable<TimeSlots> TimeSlots => _context.TimeSlots;
    }
}
