using System;
using System.Collections.Generic;
using System.Linq;
using FakeXiechengAPI.Database;
using FakeXiechengAPI.Models;

namespace FakeXiechengAPI.Services
{
    public class TouristRouteRepo : ITouristRouteRepo
    {
        private readonly AppDbContext context;

        // constructor
        public TouristRouteRepo(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return context.TouristRoutes;
        }

        public TouristRoute GetTouristRouteById(Guid touristRouteId)
        {
            // linq
            return context.TouristRoutes.FirstOrDefault(n => n.Id == touristRouteId);
        }
    }
}