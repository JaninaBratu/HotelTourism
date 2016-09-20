using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    [Table("tblCity")]
    public class City
    {
        [Key]
        public int CityId { get; set; } 
        public string Name { get; set; }

        public virtual County County { get; set; }
    }
}
