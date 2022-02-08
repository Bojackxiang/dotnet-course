using System;
using System.Collections.Generic;
using System.Linq;
using FakeXiechengAPI.Models;

namespace FakeXiechengAPI.Services
{
    public class MockTouristRouteRepo : ITouristRouteRepo
    {
        private List<TouristRoute> _routes;
        
        // constructor
        public MockTouristRouteRepo()
        {
            if (_routes == null) InitialRouteData();
        }
        
        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return _routes;
        }

        public TouristRoute GetTouristRouteById(Guid touristRouteId)
        {
            // linq
            return _routes.FirstOrDefault(n => n.Id == touristRouteId);
        }


        private void InitialRouteData()
        {
            _routes = new List<TouristRoute>
            {
                new TouristRoute
                {
                    Id = Guid.NewGuid(),
                    Title = "黄山",
                    Description = "黄山真好玩！",
                    OriginalPrice = 998,
                    Features = "<p>吃住行旅游</p>",
                    Fees = "<p>交通费用自理</p>",
                    Notes = "<p>小心危险</p>"
                }
            };
        }
    }
}