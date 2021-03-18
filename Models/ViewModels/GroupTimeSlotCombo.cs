using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleToursProject.Models.ViewModels
{
    public class GroupTimeSlotCombo
    {
        public GroupInfo GroupInfo { get; set; }
        public IEnumerable<TimeSlots> TimeSlots { get; set; }
    }
}
