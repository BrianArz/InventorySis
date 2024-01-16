using Microsoft.AspNetCore.Mvc;
using SistemaInventario.DataAccess.Repository.IRepository;

namespace SistemaInventario.Areas.Admin.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly IUnitWork _unitWork;

        public WarehouseController(IUnitWork unitWork)
        {
            _unitWork = unitWork;
        }

        public IActionResult Index()
        {
            return View();
        }


        #region API

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var all = await _unitWork.Warehouse.GetAll();
            return Json(new { data = all });
        }

        #endregion
    }
}
