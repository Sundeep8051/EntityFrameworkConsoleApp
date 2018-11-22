using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEntity
{
    public class MusicStoreDBContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
    }
}
