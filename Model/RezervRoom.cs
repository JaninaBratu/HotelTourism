using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    [Table("tblRezervationRoom")]
    public class RezervationRoom
    {
        [Key]
        public int RezervationRoomId { get; set; }

        public virtual Room Room { get; set; }
        public virtual Rezervation Rezervation { get; set; }

    }
}
