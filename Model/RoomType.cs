using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    [Table("tblRoomType")]
    public class RoomType
    {

        [Key]
        public int RoomTypeId { get; set; }
        public string Name { get; set; }
    }
}
