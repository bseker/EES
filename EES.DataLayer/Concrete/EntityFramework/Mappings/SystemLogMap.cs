using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EES.Entities.Concrete;

namespace EES.DataLayer.Concrete.EntityFramework.Mappings
{
    public class SystemLogMap : EntityTypeConfiguration<SystemLog>
    {
        public SystemLogMap()
        {
            HasKey(x => x.LogId);
        }
    }
}
