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
            var data = await _actorsService.GetAllAsync();
            return View(data); // Truyền model đúng kiểu vào View
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("fullname,ProfilePictureURL,bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorsService.AddAsync(actor);
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);

            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound"); // View lỗi
            return View(actorDetails);
        }



        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,fullname,ProfilePictureURL,bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorsService.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound"); // View lỗi nếu không tìm thấy actor
            return View(actorDetails);  // Trả về view xác nhận xóa
        }



        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Deleteconfirmed(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound"); // View lỗi nếu không tìm thấy actor
            await _actorsService.DeleteAsync(id); // Thực hiện xóa actor

            return RedirectToAction(nameof(Index)); // Quay lại trang Index sau khi xóa thành công
        }

    }
}