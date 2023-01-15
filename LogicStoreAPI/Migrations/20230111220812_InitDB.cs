using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogicStoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemPictures",
                columns: table => new
                {
                    PictureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    PictureString = table.Column<string>(type: "varchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPictures", x => x.PictureId);
                });

            migrationBuilder.CreateTable(
                name: "StoreItems",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Condition = table.Column<int>(type: "int", nullable: false),
                    ItemPrice = table.Column<float>(type: "real", nullable: false),
                    ItemCost = table.Column<float>(type: "real", nullable: false),
                    ItemDescription = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    ItemPicture = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    InStock = table.Column<int>(type: "int", nullable: false),
                    ItemSKU = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ItemWeight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreItems", x => x.ItemID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemPictures");

            migrationBuilder.DropTable(
                name: "StoreItems");
        }
    }
}
