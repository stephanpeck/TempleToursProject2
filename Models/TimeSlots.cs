using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleToursProject.Models
{
    public class TimeSlots
    {
        [Key]
        public int TimeSlotsId { get; set; }

        public DateTime TimeSlot { get; set; }

        public bool Scheduled { get; set; } = false;


    }
}
