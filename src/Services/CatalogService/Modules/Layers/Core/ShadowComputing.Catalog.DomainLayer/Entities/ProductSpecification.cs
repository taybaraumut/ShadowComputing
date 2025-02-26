using ShadowComputing.Catalog.DomainLayer.Common;

namespace ShadowComputing.Catalog.DomainLayer.Entities
{
    public class ProductSpecification : ProductBaseEntity
    {
        public string Processor { get; set; } = default!;
        public string Ram { get; set; } = default!;
        public string Storage { get; set; } = default!;
        public string GraphicsCard { get; set; } = default!;
        public string Display { get; set; } = default!;
        public string OperatingSystem { get; set; } = default!;
        public string BatteryLife { get; set; } = default!;
        public string Weight { get; set; } = default!;

        public virtual Product Product { get; set; } = default!;
    }
}
