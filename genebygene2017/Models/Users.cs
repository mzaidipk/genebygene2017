using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace genebygene2017.Models
{
    public class Users
    {
        public Users()
        {
            Samples = new HashSet<Samples>();
        }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName { get { return this.LastName + ", " + this.FirstName; } }
        public virtual ICollection<Samples> Samples { get; set; }
    }
}
