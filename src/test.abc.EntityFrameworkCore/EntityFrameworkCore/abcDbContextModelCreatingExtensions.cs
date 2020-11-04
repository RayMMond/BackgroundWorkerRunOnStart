using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace test.abc.EntityFrameworkCore
{
    public static class abcDbContextModelCreatingExtensions
    {
        public static void Configureabc(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(abcConsts.DbTablePrefix + "YourEntities", abcConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}