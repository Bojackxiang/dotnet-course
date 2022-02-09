using FakeXiechengAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FakeXiechengAPI.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // 给 entity framework 添加表
        // 后面的 名称就是 表的名称
        public DbSet<TouristRoute> TouristRoutes { get; set; }
        public DbSet<TouristRoutePicture> TouristRoutePictures { get; set; }
    }
}