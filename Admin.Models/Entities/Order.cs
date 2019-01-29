using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.Models.Abstract;
using Admin.Models.Enum;

namespace Admin.Models.Entities
{
    [Table("Orders")]
    public class Order:BaseEntitiy<long>
    {
        public OrderTypes OrderTypes { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }=new HashSet<Invoice>();

    }
}
