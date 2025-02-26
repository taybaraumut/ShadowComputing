
namespace ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductSpecificationDtos
{
    public class UpdateProductSpecificationDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Processor { get; set; } = default!;
        public string Ram { get; set; } = default!;
        public string Storage { get; set; } = default!;
        public string GraphicsCard { get; set; } = default!;
        public string Display { get; set; } = default!;
        public string OperatingSystem { get; set; } = default!;
        public string BatteryLife { get; set; } = default!;
        public string Weight { get; set; } = default!;
    }
}
