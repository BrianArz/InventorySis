using Microsoft.AspNetCore.Mvc;
using SistemaInventario.DataAccess.Repository.IRepository;

namespace SistemaInventario.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WarehouseController(IUnitWork unitWork) : Controller
    {
        public IUnitWork UnitWork { get; set; } = unitWork;

        public IActionResult Index()
        {
            return View();
        }

        #region API

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var all = await UnitWork.Warehouse.GetAll();
            return Json(new { data = all });
        }

        #endregion
    }
}
