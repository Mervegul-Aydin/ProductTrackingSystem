using MyJeweleryShop.Core.UnitOfWorks;


namespace MyJeweleryShop.Repository.UnitOfWorks
{
    public class UnitOfWork : IGenericUnitOfWork
    {
        private readonly AppDbContexts.AppDbContext.AppDbContext _context;

        public UnitOfWork(AppDbContexts.AppDbContext.AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

    }

}
