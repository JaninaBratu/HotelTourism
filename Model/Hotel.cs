using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("tblHotel")]
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        public string Name { get; set; }

        public virtual City City { get; set; }
    }
}
