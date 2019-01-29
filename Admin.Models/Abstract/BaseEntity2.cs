using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.Models.Abstract
{
    public abstract class BaseEntity2<T1,T2>:BaseEntitiy<T1>
    {

        [Key]
        [Column(Order = 2)]
        public T2 Id2 { get; set; }



    }
}
