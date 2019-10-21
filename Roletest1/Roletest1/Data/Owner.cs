using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Roletest1.Data
{
    public class Owner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OID { get; set; }
        public int ON { get; set; }
        public int OL { get; set; }

        //foreign key
        public int RID { get; set; }

        [ForeignKey("RID")]
        public Role Roles { get; set; }
    }
}
