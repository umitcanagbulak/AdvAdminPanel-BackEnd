using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class BaseEntity: BaseEntity<int> { }

    public class BaseEntity<T> : IEntity
    {
        public virtual T Id { get; set; }
    }
}
