using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    [Table("tblFacilityRoom")]
    public class FacilityRoom
    {
        [Key]
        public int FacilityRoomId { get; set; }

        public ICollection<Room> Rooms { get; set; }
        public ICollection<Facility> Facilities { get; set; }
         
    }
}
