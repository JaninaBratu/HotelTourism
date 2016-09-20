using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    [Table("tblRoom")]
    public class Room
    {

        [Key]
        public int RoomId { get; set; }
        public float Price { get; set; }

        public virtual ICollection<RoomType> RoomTypes { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
