using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    [Table("tblRezervation")]
    public class Rezervation
    {

        [Key]
        public int RezervationId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual Room Room { get; set; }

    }
}
