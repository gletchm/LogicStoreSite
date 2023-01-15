using LogicStoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LogicStoreAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        public DbSet<ItemPicture> ItemPictures { get; set; }
        
        public DbSet<StoreItem> StoreItems { get; set; }

    }
}
