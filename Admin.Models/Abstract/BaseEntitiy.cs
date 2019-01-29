using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Models.Abstract
{
    public abstract class BaseEntitiy<T>
    {

        [Key]
        [Column(Order = 1)]
        public T Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedTime { get; set; }
    }


}
