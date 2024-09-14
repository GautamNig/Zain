using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using Common.Library;
using WpfZain.DataLayer.EntityClasses;

namespace WpfZain.DataLayer.Models
{
    public partial class SampleDbContext : DbContext
    {
        public SampleDbContext() : base("name=Samples")
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }
}