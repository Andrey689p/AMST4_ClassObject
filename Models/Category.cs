using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMST4_ClassObject.Models
{
    public class Category : EntityBase
    {
        public Category(string categorydescription)
        {
            CategoryDescription = categorydescription;
        }
        public string CategoryDescription { get; private set; } = string.Empty;
    }
}