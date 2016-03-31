using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ZhongHong.Core
{
    public class ZhongHongContext : DbContext
    {
        /// <summary>
        /// 管理员集合
        /// </summary>
        public DbSet<Administrator> Administrator { get; set; }

        public ZhongHongContext()
            : base("MSSQLConnectionString")
        {
            Database.SetInitializer<ZhongHongContext>(new CreateDatabaseIfNotExists<ZhongHongContext>());
        }
    }
}
