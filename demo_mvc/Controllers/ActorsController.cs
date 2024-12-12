using demo_mvc.Data;
using demo_mvc.Data.Service;
using demo_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_mvc.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _actorsService;

        public ActorsController(IActorsService actorsService)
        {
            _actorsService = actorsService;
        }

        public async Task<IActionResult> Index()
        {
            // Đảm bảo sử dụng await để lấy dữ liệu thực tế
            var data = await _actorsService.GetAll();
            return View(data); // Truyền model đúng kiểu vào View
        }
        public IActionResult Create()
        {
            // Tạo một đối tượng Actor rỗng và truyền vào View
            var actor = new Actor();
            return View(actor);
        }
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = _actorsService.GetById(id);

            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
        }

    }

}
