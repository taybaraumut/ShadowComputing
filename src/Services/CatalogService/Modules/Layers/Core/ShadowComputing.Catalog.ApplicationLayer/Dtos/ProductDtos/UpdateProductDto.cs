
using Microsoft.AspNetCore.Http;

namespace ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductDtos
{
    public class UpdateProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Model { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public string Manufacturer { get; set; } = default!;
        public string SerialNumber { get; set; } = default!;
        public string ReturnPolicy { get; set; } = default!;

        public string EstimatedDeliveryTime { get; set; } = default!;

        public decimal Price { get; set; }
        public decimal Weight { get; set; }

        public int StockQuantity { get; set; }
        public int WarrantyPeriod { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DiscontinuedAt { get; set; }

        public bool IsNewArrival { get; set; }
        public bool IsBestSeller { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsActive { get; set; }

        public IFormFile ImageFile { get; set; } = default!;
    }
}
