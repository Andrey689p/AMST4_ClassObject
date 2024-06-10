using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMST4_ClassObject.Models
{
    public class EntityBase
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
            IsActive = true;
        }
        public Guid Id { get; private set; }
        public bool IsActive { get; private set; }
    }
}