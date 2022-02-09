using FakeXiechengAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FakeXiechengAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristRoutesController : ControllerBase
    {
        private readonly ITouristRouteRepo _touristRouteRepo;

        // 因为 在 configure service 中已经注入了service，所以
        // 这边 直接就能在 项目中找到 repo，然后进行赋值
        public TouristRoutesController(ITouristRouteRepo touristRouteRepo)
        {
            _touristRouteRepo = touristRouteRepo;
        }

        public IActionResult GetTouristRoutes()
        {
            var routes = _touristRouteRepo.GetTouristRoutes();
            return Ok(routes);
        }
    }
}