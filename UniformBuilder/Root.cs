using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformBuilder
{
    public abstract class Root
    {
        public virtual Guid Id { get; set; }
        public virtual User Creator { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual User LastUpdatedBy { get; set; }
        public virtual DateTime LastUpdateDate { get; set; }
    }
}
