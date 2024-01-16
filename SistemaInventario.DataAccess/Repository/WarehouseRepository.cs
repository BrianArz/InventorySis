using SistemaInventario.DataAccess.Data;
using SistemaInventario.DataAccess.Repository.IRepository;
using SistemaInventario.Models;

namespace SistemaInventario.DataAccess.Repository
{
    public class WarehouseRepository : Repository<Warehouse>, IWarehouseRepository
    {
        private readonly ApplicationDbContext _db;

        public WarehouseRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Warehouse warehouse)
        {
            var warehouseBd = _db.Warehouses.FirstOrDefault(w => w.Id.Equals(warehouse.Id));

            if (warehouseBd != null)
            {
                warehouseBd.Name = warehouse.Name;
                warehouseBd.Description = warehouse.Description;
                warehouseBd.Status = warehouse.Status;
                _db.SaveChanges();
            }
        }
    }
}
