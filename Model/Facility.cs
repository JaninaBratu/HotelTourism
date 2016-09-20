using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    [Table("tblFacility")]
    public class Facility
    {

        [Key]
        public int FacilityId { get; set; }
        public string Name { get; set; }
    }
}
