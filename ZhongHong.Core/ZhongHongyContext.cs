using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ZhongHong.Core
{
    public class ZhongHongyContext:DbContext
    {
        public ZhongHongyContext(): base("DefaultConnection")
        {
            Database.SetInitializer<ZhongHongyContext>(new CreateDatabaseIfNotExists<ZhongHongyContext>());
        }
    }
}
