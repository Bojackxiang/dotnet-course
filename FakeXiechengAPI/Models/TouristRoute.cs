using System;
using System.Collections.Generic;

namespace FakeXiechengAPI.Models
{
    public class TouristRoute
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal OriginalPrice { get; set; }
        public double? DiscountPresent { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public DateTime? DepartureTime { get; set; }

        // string 本来就可以是 nullable，所以不用加上问号，但是double 和 datetime不一样
        public string Features { get; set; }
        public string Fees { get; set; }
        public string Notes { get; set; }

        // ICollection 可以理解为一个 全都是其他class 的array
        public ICollection<TouristRoutePicture> TouristRoutePictures { get; set; }
    }
}