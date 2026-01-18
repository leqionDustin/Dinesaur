using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class submit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<int>(type: "int", nullable: true),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLoginAtUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DinesaurUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DinesaurUserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DinesaurUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DinesaurUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.FoodID);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantID = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Catergories = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "PreOrder",
                columns: table => new
                {
                    PreOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    ReservationID = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreOrder", x => x.PreOrderID);
                });

            migrationBuilder.CreateTable(
                name: "PreOrderItem",
                columns: table => new
                {
                    PreorderItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PreOrderID = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreOrderItem", x => x.PreorderItemID);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ReservationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time", nullable: false),
                    Pax = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantID = table.Column<int>(type: "int", nullable: false),
                    ReviewID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ReservationID);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    RestaurantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminID = table.Column<int>(type: "int", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningHours = table.Column<TimeOnly>(type: "time", nullable: false),
                    ClosingHours = table.Column<TimeOnly>(type: "time", nullable: false),
                    RestaurantOwnerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contact = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.RestaurantID);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Administrator", "ADMINISTRATOR" },
                    { "2", null, "User", "USER" },
                    { "3", null, "RestaurantStaff", "RESTAURANTSTAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Contact", "CreatedAtUtc", "Email", "EmailConfirmed", "LastLoginAtUtc", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "27bc5419-5b66-4a63-8682-d3a0500e320f", 91234567, new DateTime(2026, 1, 18, 14, 27, 34, 446, DateTimeKind.Utc).AddTicks(7754), "admin@localhost.com", true, null, false, null, "Admin", "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEErvgXYIq2qPbMFNqNu/0CkMtuwuWiFhgTDwFJ0IgPGK0n5jEI1bhrlaBuwLOl3Ibw==", null, false, "db748e79-9140-493c-a3ac-c561c9c89d2d", false, "admin@localhost.com" },
                    { "10", 0, "51b514fa-a8c6-4b09-a189-3706174d5fc2", 97629623, new DateTime(2026, 1, 18, 14, 27, 35, 80, DateTimeKind.Utc).AddTicks(774), "dustindomingo@gmail.com", true, null, false, null, "Dustin", "DUSTINDOMINGO@GMAIL.COM", "DUSTINDOMINGO@GMAIL.COM", "AQAAAAIAAYagAAAAEKrElxKNNETn4+X3ZguuJrlvTI4B9L72Rsvtga8g7wUb8YTVukVDHHRs1HqFXHE40w==", null, false, "e5b31737-0682-42eb-8f75-c9d0395b8bd5", false, "dustindomingo@gmail.com" },
                    { "11", 0, "f04d34b5-3675-4d7b-831b-e36ddcb43581", 97237323, new DateTime(2026, 1, 18, 14, 27, 35, 146, DateTimeKind.Utc).AddTicks(8447), "restaurantstaff@localhost.com", true, null, false, null, "RestaurantStaff", "RESTAURANTSTAFF@localhost.COM", "RESTAURANTSTAFF@localhost.COM", "AQAAAAIAAYagAAAAEP9TfJ/Z/mHycRuaDORw+W22szXLNLMaHjBOSv7SAQCAl1Y4gD5/Y1kwql8Ms4UDPg==", null, false, "38ded9b2-8e60-4517-b782-f1417f708dd6", false, "restaurantstaff@localhost.com" },
                    { "2", 0, "ab9f7552-a082-4333-8a44-8abe97712409", 97826235, new DateTime(2026, 1, 18, 14, 27, 34, 501, DateTimeKind.Utc).AddTicks(170), "user@localhost.com", true, null, false, null, "User", "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGG91mxaxLxOn5SVcsFSOyK2Il+vo3ThgWiIEBOMxVT9DCsx4vsWqOhiqpSU9oYLWw==", null, false, "5c59b438-9bbd-4e20-b995-58f955e3ae15", false, "user@localhost.com" },
                    { "3", 0, "9554de2b-b416-4014-8ded-97fdf48beb1f", 82613992, new DateTime(2026, 1, 18, 14, 27, 34, 556, DateTimeKind.Utc).AddTicks(5922), "Tomahawk@gmail.com", true, null, false, null, "Tomahawk Admin", "TOMAHAWK@GMAIL.COM", "TOMAHAWK@GMAIL.COM", "AQAAAAIAAYagAAAAEG499BUzVAel05E2o472QAoPdjlS3hXScTHMimyerKeupegJ0sWJdcBKqmmauOYVOg==", null, false, "a28d61ea-3268-446b-af08-c58304f75e45", false, "Tomahawk@gmail.com" },
                    { "4", 0, "a40e2866-a649-4681-833e-a02cf41e4bc8", 82613992, new DateTime(2026, 1, 18, 14, 27, 34, 618, DateTimeKind.Utc).AddTicks(4334), "ButcherBlock@gmail.com", true, null, false, null, "ButcherAdmin", "BUTCHERBLOCK@GMAIL.COM", "BUTCHERBLOCK@GMAIL.COM", "AQAAAAIAAYagAAAAEEbT/ekY+JiVFGObRwS9DRu3QCexygoW9shZB5+shNaWBo8T3rT9JTB7xIH0XYWL/Q==", null, false, "b8526414-d018-487d-9abf-c4936145cf8b", false, "ButcherBlock@gmail.com" },
                    { "5", 0, "ed57dbb3-c5ff-4455-b0f5-98ffd1b59fd8", 88706606, new DateTime(2026, 1, 18, 14, 27, 34, 692, DateTimeKind.Utc).AddTicks(2313), "labula@gmail.com", true, null, false, null, "LabulaAdmin", "LABULA@GMAIL.COM", "LABULA@GMAIL.COM", "AQAAAAIAAYagAAAAEGqwoWJ8lezm7fh8fIdm1aQLcnWAvIUWQ99FL/DNl64swKk1yDTiL+Ok6FKQt6svBA==", null, false, "6382b4e0-5181-4095-9a49-395c85d780ee", false, "labula@gmail.com" },
                    { "6", 0, "af3240cf-7810-4c90-8c3e-1ff670c94786", 94799101, new DateTime(2026, 1, 18, 14, 27, 34, 751, DateTimeKind.Utc).AddTicks(7286), "chefhats@gmail.com", true, null, false, null, "ChefHatsAdmin", "CHEFHATS@GMAIL.COM", "CHEFHATS@GMAIL.COM", "AQAAAAIAAYagAAAAEJ67ei5iEqoBM2LXCzPTVfBE08r5U4/nYJlMXB8jAPf5W9LLn7dupLxAaNEOXK9R9A==", null, false, "d429bb53-b62e-417c-a859-569f4bb23e5c", false, "chefhats@gmail.com" },
                    { "7", 0, "2aa7d543-3860-4caa-86d6-5b514056dff0", 91234560, new DateTime(2026, 1, 18, 14, 27, 34, 832, DateTimeKind.Utc).AddTicks(3170), "tdp@gmail.com", true, null, false, null, "TDPAdmin", "TDP@GMAIL.COM", "TDP@GMAIL.COM", "AQAAAAIAAYagAAAAELkWXZ7uc2QXvm/FXs2LNbXHDf9YV+c+8e/DVqyLx+7Plu1WoMgFKc2+g3MZm0RKVg==", null, false, "b8ddeb9d-cd53-4224-9d47-69e71607fdad", false, "tdp@gmail.com" },
                    { "8", 0, "960b05cc-3968-443c-9f47-ef4ba8c19304", 96409718, new DateTime(2026, 1, 18, 14, 27, 34, 916, DateTimeKind.Utc).AddTicks(2370), "oliverchay@gmail.com", true, null, false, null, "Oliver", "OLIVERCHAY@GMAIL.COM", "OLIVERCHAY@GMAIL.COM", "AQAAAAIAAYagAAAAEIAwLVtXm1/1m0LAmJos6qRljCdjqfjNSSnHlvryueExq9pEBomGS5JH6tETnbSWdQ==", null, false, "b5ad44a9-dbec-4eed-8b68-cfc9a28a8da9", false, "oliverchay@gmailcom" },
                    { "9", 0, "f91cfc77-3e51-42b7-9455-8f4394d2082a", 93278292, new DateTime(2026, 1, 18, 14, 27, 34, 995, DateTimeKind.Utc).AddTicks(6864), "ryanneo@gmail.com", true, null, false, null, "Ryan", "RYANNEO@GMAIL.COM", "RYANNEO@GMAIL.COM", "AQAAAAIAAYagAAAAEIMW/JJpe+bq0bwBoTZNSjTGmkm7dJnjVbszFufxxeXyplwB4e/9poBHqbZH+fTneA==", null, false, "88ac8987-b86d-4906-822c-6e77fa56a9f4", false, "ryanneo@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "DinesaurUser",
                columns: new[] { "Id", "Contact", "DinesaurUserID", "DinesaurUserName", "Email" },
                values: new object[,]
                {
                    { 1, 97826235, "2", "User", "user@localhost.com" },
                    { 2, 96409718, "8", "Oliver", "user@localhost.com" },
                    { 3, 93278292, "9", "Ryan", "user@localhost.com" },
                    { 4, 97629623, "10", "Dustin", "dustindomingo@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "FoodID", "Category", "Cost", "Description", "FoodName", "Image", "MenuID", "StaffID" },
                values: new object[,]
                {
                    { 1, "Meat", 3.5, "White meat", "Chicken", "[\"/Images/FoodDisplay.jpg\"]", 1, "999" },
                    { 2, "Seafood", 4.0, "Saba", "Fish", "[\"/Images/Veg.jpg\"]", 1, "9999" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "MenuID", "Category", "Catergories", "RestaurantID" },
                values: new object[,]
                {
                    { 1, "", "[\"Meat\",\"Seafood\"]", 1 },
                    { 2, "", "[]", 9998 }
                });

            migrationBuilder.InsertData(
                table: "PreOrder",
                columns: new[] { "PreOrderID", "Cost", "MenuID", "Remarks", "ReservationID" },
                values: new object[,]
                {
                    { 1, 3.5, 1, "Please remove the onions", 1 },
                    { 2, 4.0, 2, "Please remove all vegetables", 2 }
                });

            migrationBuilder.InsertData(
                table: "PreOrderItem",
                columns: new[] { "PreorderItemID", "FoodID", "PreOrderID", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 1, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "ReservationID", "CustomerID", "Date", "Pax", "Remarks", "RestaurantID", "ReviewID", "Status", "Time" },
                values: new object[,]
                {
                    { 1, "8", new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "N/A", 1, null, 0, new TimeOnly(12, 30, 0) },
                    { 2, "8", new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "N/A", 2, null, 3, new TimeOnly(18, 30, 0) },
                    { 3, "8", new DateTime(2026, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "1 Baby Chair", 1, null, 4, new TimeOnly(13, 30, 0) },
                    { 4, "9", new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "N/A", 3, null, 0, new TimeOnly(14, 30, 0) },
                    { 5, "9", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "N/A", 2, null, 3, new TimeOnly(19, 30, 0) },
                    { 6, "9", new DateTime(2026, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "N/A", 3, null, 1, new TimeOnly(14, 30, 0) }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantID", "AdminID", "Category", "ClosingHours", "Contact", "CreatedAtUtc", "Email", "Location", "Logo", "OpeningHours", "RestaurantName", "RestaurantOwnerID", "Status" },
                values: new object[,]
                {
                    { 1, 1, "Western", new TimeOnly(22, 0, 0), 82613992, new DateTime(2026, 1, 18, 14, 27, 34, 446, DateTimeKind.Utc).AddTicks(7439), "tomahawk@gmail.com", "273, #01-06 Thomson Rd, Novena Gardens, Singapore 307644", "[\"/Images/Tomahawk.jpeg\"]", new TimeOnly(12, 0, 0), "Tomahawk Contemporary Steakhouse", "3", 1 },
                    { 2, 1, "Fine Dining", new TimeOnly(21, 30, 0), 64121816, new DateTime(2026, 1, 18, 14, 27, 34, 446, DateTimeKind.Utc).AddTicks(7446), "ButcherBlock@gmail.com", "328 N Bridge Rd, #02-02 RAFFLES ARCADE, Singapore 188719", "[\"/Images/Butcher.jpg\"]", new TimeOnly(12, 0, 0), "Butcher's Block", "4", 1 },
                    { 3, 1, "HotPot", new TimeOnly(22, 30, 0), 88706606, new DateTime(2026, 1, 18, 14, 27, 34, 446, DateTimeKind.Utc).AddTicks(7450), "labula@gmail.com", "681 Punggol Dr., #01-07, Singapore 820681", "[\"/Images/LABULA.jpg\"]", new TimeOnly(10, 30, 0), "辣不辣 Labula Mala Sichuan Restaurant", "5", 1 },
                    { 4, 1, "Western", new TimeOnly(22, 0, 0), 94799101, new DateTime(2026, 1, 18, 14, 27, 34, 446, DateTimeKind.Utc).AddTicks(7453), "chefhats@gmail.com", "21 Hougang St 51, #01-01A Hougang GREEN Shopping Mall, Singapore 538719", "[\"/Images/Chef.jpg\"]", new TimeOnly(10, 0, 0), "Chef's Hats", "6", 0 },
                    { 5, 1, "Dessert", new TimeOnly(17, 30, 0), 94350556, new DateTime(2026, 1, 18, 14, 27, 34, 446, DateTimeKind.Utc).AddTicks(7456), "tdp@gmail.com", "406 Tampines Street 41, #01-23 Sun Plaza Green, Singapore 520406", "[\"/Images/tdp.jpeg\"]", new TimeOnly(11, 30, 0), "The Dessert Party", "7", 2 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewID", "CustomerID", "Date", "Description", "Rating", "RestaurantID", "ReviewTitle", "Status" },
                values: new object[,]
                {
                    { 1, "2", new DateTime(2026, 1, 18, 22, 27, 34, 446, DateTimeKind.Local).AddTicks(7527), "Friendly staff and quick service. Will come again.", 4.5, 1, "Excellent Service", 0 },
                    { 2, "8", new DateTime(2026, 1, 18, 22, 27, 34, 446, DateTimeKind.Local).AddTicks(7540), "Food was okay, but waiting time was a bit long.", 3.0, 2, "Average Experience", 0 },
                    { 3, "10", new DateTime(2026, 1, 18, 22, 27, 34, 446, DateTimeKind.Local).AddTicks(7541), "Food quality was great and portions were generous.", 4.0, 3, "Great Food", 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "10" },
                    { "3", "11" },
                    { "2", "2" },
                    { "3", "3" },
                    { "3", "4" },
                    { "3", "5" },
                    { "3", "6" },
                    { "3", "7" },
                    { "2", "8" },
                    { "2", "9" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DinesaurUser");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "PreOrder");

            migrationBuilder.DropTable(
                name: "PreOrderItem");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
