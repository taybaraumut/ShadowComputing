﻿
using Microsoft.AspNetCore.Http;

namespace ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductStandardDescriptionDtos
{
    public class CreateProductStandardDescriptionDto
    {
        public Guid ProductId { get; set; }
        public Guid ProductDetailId { get; set; } = default!;
        public string Title { get; set; } = default!;

        public string ImageUrl { get; set; } = default!;
        public string Description { get; set; } = default!;
        public IFormFile ImageFile { get; set; } = default!;
    }
}
