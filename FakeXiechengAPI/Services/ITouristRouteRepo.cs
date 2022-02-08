using System;
using System.Collections.Generic;
using FakeXiechengAPI.Models;

namespace FakeXiechengAPI.Services
{
    public interface ITouristRouteRepo
    {
        IEnumerable<TouristRoute> GetTouristRoutes();
        TouristRoute GetTouristRouteById(Guid touristRouteId);
    }
}