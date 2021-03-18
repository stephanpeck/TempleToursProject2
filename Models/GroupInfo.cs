using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleToursProject.Models
{
    //Class for the group info
    public class GroupInfo
    {
        //Primary key for the Group Info 
        [Key]
        public int GroupInfoId { get; set; }

        [Required]
        public string GroupName { get; set; }

        [Required]
        [Range(1,50)]
        public int GroupSize { get; set; }

        [Required]
        public string Email { get; set; }

        //Phone is the only property that is not required to be entered.
        public string Phone { get; set; }

        public string SelectedAppointmentDay { get; set; }

        public string SelectedAppointmentTime { get; set; }

    }
}
