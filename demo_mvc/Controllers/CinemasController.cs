using demo_mvc.Data;
using demo_mvc.Data.Service;
using demo_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace demo_mvc.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemaService _cinemaService;

        public CinemasController(ICinemaService cinemasService)
        {
            _cinemaService = cinemasService;
        }

        public async Task<IActionResult> Index()
        {
            // Đảm bảo sử dụng await để lấy dữ liệu thực tế
            var data = await _cinemaService.GetAllAsync();
            return View(data); // Truyền model đúng kiểu vào View
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Logo,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _cinemaService.AddAsync(cinema);
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _cinemaService.GetByIdAsync(id);

            if (cinemaDetails == null) return View("Empty");
            return View(cinemaDetails);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _cinemaService.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound"); // View lỗi
            return View(actorDetails);
        }



        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Logo,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _cinemaService.UpdateAsync(id, cinema);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _cinemaService.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound"); 
            return View(actorDetails); 
        }



        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Deleteconfirmed(int id)
        {
            var actorDetails = await _cinemaService.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound"); 
            await _cinemaService.DeleteAsync(id);

            return RedirectToAction(nameof(Index)); 
        }

    }
}
