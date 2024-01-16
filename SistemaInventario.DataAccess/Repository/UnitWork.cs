using SistemaInventario.DataAccess.Data;
using SistemaInventario.DataAccess.Repository.IRepository;

namespace SistemaInventario.DataAccess.Repository
{
    public class UnitWork : IUnitWork
    {
        private readonly ApplicationDbContext _db;

        public IWarehouseRepository Warehouse { get; private set; }

        public UnitWork(ApplicationDbContext db)
        {
            _db = db;
            Warehouse = new WarehouseRepository(_db);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}
