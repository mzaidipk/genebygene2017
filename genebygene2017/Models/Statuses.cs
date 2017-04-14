using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace genebygene2017.Models
{
    public class Statuses
    {
        public Statuses()
        {
            Samples = new HashSet<Samples>();
        }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Samples> Samples { get; set; }
    }
}
