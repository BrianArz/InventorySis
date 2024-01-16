namespace SistemaInventario.DataAccess.Repository.IRepository
{
    public interface IUnitWork : IDisposable
    {
        IWarehouseRepository Warehouse { get; }

        Task Save();
    }
}
