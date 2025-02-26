using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShadowComputing.Catalog.PersistenceLayer.Migrations
{
    /// <inheritdoc />
    public partial class shadowcomputing_catalog_create_database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "shadow-computing");

            migrationBuilder.CreateTable(
                name: "products",
                schema: "shadow-computing",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    model = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    manufacturer = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    image_url = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    serial_number = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    return_policy = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    stock_quantity = table.Column<int>(type: "int", nullable: false),
                    warranty_Period = table.Column<int>(type: "int", nullable: false),
                    weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    estimated_delivery_time = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    discontinued_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    is_new_arrival = table.Column<bool>(type: "bit", nullable: false),
                    is_best_seller = table.Column<bool>(type: "bit", nullable: false),
                    is_featured = table.Column<bool>(type: "bit", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "product_brands",
                schema: "shadow-computing",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    product_id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    image_url = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_brands", x => x.id);
                    table.ForeignKey(
                        name: "FK_product_brands_products_product_id",
                        column: x => x.product_id,
                        principalSchema: "shadow-computing",
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "product_comments",
                schema: "shadow-computing",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    product_id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    user_id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_comments", x => x.id);
                    table.ForeignKey(
                        name: "FK_product_comments_products_product_id",
                        column: x => x.product_id,
                        principalSchema: "shadow-computing",
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "product_details",
                schema: "shadow-computing",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    product_id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_details", x => x.id);
                    table.ForeignKey(
                        name: "FK_product_details_products_product_id",
                        column: x => x.product_id,
                        principalSchema: "shadow-computing",
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "product_images",
                schema: "shadow-computing",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    product_id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    product_detail_id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    small_image_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    big_image_url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_images", x => x.id);
                    table.ForeignKey(
                        name: "FK_product_images_products_product_id",
                        column: x => x.product_id,
                        principalSchema: "shadow-computing",
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "product_seos",
                schema: "shadow-computing",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    product_id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    seo_title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    seo_description = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
                    seo_keywords = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_seos", x => x.id);
                    table.ForeignKey(
                        name: "FK_product_seos_products_product_id",
                        column: x => x.product_id,
                        principalSchema: "shadow-computing",
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "product_specifications",
                schema: "shadow-computing",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    product_id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    processor = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    graphics_card = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ram = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    storage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    display = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    operating_system = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    battery_life = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    weight = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_specifications", x => x.id);
                    table.ForeignKey(
                        name: "FK_product_specifications_products_product_id",
                        column: x => x.product_id,
                        principalSchema: "shadow-computing",
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "product_advanced_descriptions",
                schema: "shadow-computing",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    product_id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    product_detail_id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    title = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    image_url = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    video_url = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_advanced_descriptions", x => x.id);
                    table.ForeignKey(
                        name: "FK_product_advanced_descriptions_product_details_product_detail_id",
                        column: x => x.product_detail_id,
                        principalSchema: "shadow-computing",
                        principalTable: "product_details",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "product_basic_descriptions",
                schema: "shadow-computing",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    product_id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    product_detail_id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    title = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_basic_descriptions", x => x.id);
                    table.ForeignKey(
                        name: "FK_product_basic_descriptions_product_details_product_detail_id",
                        column: x => x.product_detail_id,
                        principalSchema: "shadow-computing",
                        principalTable: "product_details",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "product_standard_descriptions",
                schema: "shadow-computing",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    product_id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    product_detail_id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    title = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    image_url = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_standard_descriptions", x => x.id);
                    table.ForeignKey(
                        name: "FK_product_standard_descriptions_product_details_product_detail_id",
                        column: x => x.product_detail_id,
                        principalSchema: "shadow-computing",
                        principalTable: "product_details",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_product_advanced_descriptions_product_detail_id",
                schema: "shadow-computing",
                table: "product_advanced_descriptions",
                column: "product_detail_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_basic_descriptions_product_detail_id",
                schema: "shadow-computing",
                table: "product_basic_descriptions",
                column: "product_detail_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_brands_product_id",
                schema: "shadow-computing",
                table: "product_brands",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_comments_product_id",
                schema: "shadow-computing",
                table: "product_comments",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_details_product_id",
                schema: "shadow-computing",
                table: "product_details",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_images_product_id",
                schema: "shadow-computing",
                table: "product_images",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_seos_product_id",
                schema: "shadow-computing",
                table: "product_seos",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_specifications_product_id",
                schema: "shadow-computing",
                table: "product_specifications",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_standard_descriptions_product_detail_id",
                schema: "shadow-computing",
                table: "product_standard_descriptions",
                column: "product_detail_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product_advanced_descriptions",
                schema: "shadow-computing");

            migrationBuilder.DropTable(
                name: "product_basic_descriptions",
                schema: "shadow-computing");

            migrationBuilder.DropTable(
                name: "product_brands",
                schema: "shadow-computing");

            migrationBuilder.DropTable(
                name: "product_comments",
                schema: "shadow-computing");

            migrationBuilder.DropTable(
                name: "product_images",
                schema: "shadow-computing");

            migrationBuilder.DropTable(
                name: "product_seos",
                schema: "shadow-computing");

            migrationBuilder.DropTable(
                name: "product_specifications",
                schema: "shadow-computing");

            migrationBuilder.DropTable(
                name: "product_standard_descriptions",
                schema: "shadow-computing");

            migrationBuilder.DropTable(
                name: "product_details",
                schema: "shadow-computing");

            migrationBuilder.DropTable(
                name: "products",
                schema: "shadow-computing");
        }
    }
}
