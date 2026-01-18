using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class Comments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31ff5b91-1102-4a05-b4b2-d2ee2301b2ef", new DateTime(2026, 1, 18, 12, 5, 7, 327, DateTimeKind.Utc).AddTicks(1929), "AQAAAAIAAYagAAAAEFfz4akgl7RO0/L0TeYkrUqYFKU0GvKbrZTsvI3/u+sSF4sZvfLKMk/j7gPNwrrqlg==", "4f75917b-1ead-44d2-8564-b62693b89954" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbd7731f-0b3b-4e48-8167-8968ad237791", new DateTime(2026, 1, 18, 12, 5, 7, 892, DateTimeKind.Utc).AddTicks(8138), "AQAAAAIAAYagAAAAEGAvpnGQ7h2uwr0RD4XygIjamp/A4Dz0wjO4WfXXidNOXmRbvJS6k8LwHnTODywMIg==", "a4a06043-49cf-4db2-8a5b-d7a33ce6cb03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd2b98ee-52d7-42ef-a18d-4e82854dfb10", new DateTime(2026, 1, 18, 12, 5, 7, 962, DateTimeKind.Utc).AddTicks(5108), "AQAAAAIAAYagAAAAEB8qlpK4QK3u8oH58Gh+Xyn/x2eE1hzuLzSLlBiBIx/1DHOotLloeVaH83pRZkQzww==", "8b47d00d-7153-4c7f-8a39-4c1964913072" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67d96dff-721e-4d14-b2b9-d311ea85ef83", new DateTime(2026, 1, 18, 12, 5, 7, 390, DateTimeKind.Utc).AddTicks(690), "AQAAAAIAAYagAAAAEPRJRE2JvEv3ZplkKxS+EGarjkZUS17exOyoAF5hrjp4QkT26I7S54Sqr+04X7j+7w==", "4ea65fc1-26c3-416f-ac9a-e31f5c97d5da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a52a5204-256e-48f3-9014-2de042e1bc76", new DateTime(2026, 1, 18, 12, 5, 7, 455, DateTimeKind.Utc).AddTicks(622), "AQAAAAIAAYagAAAAEPR4yT6QxMI0HnI/RwWbtfvUe3aBPvoTYXHn1sPH/AsJs/PjDD7f9HfwwD/DRndHTg==", "60867c7a-720f-4ce2-89c5-354646566f86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66edff78-a6c8-468a-872c-9a698c0a69bc", new DateTime(2026, 1, 18, 12, 5, 7, 514, DateTimeKind.Utc).AddTicks(9460), "AQAAAAIAAYagAAAAEDDO6iU/5J+QEFLbxHkX2zLVR4cnVZjHi/tGW468gvD/RFfJF+B38L+kNcjvmVnOGw==", "72e3bf63-f9d7-4d2f-acfd-2f446ccd5535" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95fab67b-7f8b-447b-b5e9-edcd55480a35", new DateTime(2026, 1, 18, 12, 5, 7, 577, DateTimeKind.Utc).AddTicks(3920), "AQAAAAIAAYagAAAAEKD38mBPK9ldLllphxg80MXAqdMbyXm6DOf1+dalIbIgOBp/5xTbIR7bZRRTVCplPA==", "d70cef2f-428b-480e-8e78-0e124a9a90c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db034fb8-016c-4aaf-b05f-3aec4f57d2cb", new DateTime(2026, 1, 18, 12, 5, 7, 634, DateTimeKind.Utc).AddTicks(9027), "AQAAAAIAAYagAAAAEMG7HfHhiznny/+WJ2gKjxEgoYq3AlI+XTopPzDIcgssTadZc0ePY1eJoZtX77SeYw==", "44d0eea1-6d53-4054-9b44-dbe47facd3ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bbcdc97-bdd8-44a5-9442-3e34c07c3d96", new DateTime(2026, 1, 18, 12, 5, 7, 695, DateTimeKind.Utc).AddTicks(5811), "AQAAAAIAAYagAAAAEGzr4FXLuo5QcUSoQP2G9aYdV8Y342u77VqqNfxgtazOoemkq/XRv1tg3K1aTfPP/Q==", "3137231d-0b2e-443e-96ef-cafe744eb94f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "431876ce-98ae-47d9-85aa-63a220e47934", new DateTime(2026, 1, 18, 12, 5, 7, 752, DateTimeKind.Utc).AddTicks(5156), "AQAAAAIAAYagAAAAEOjunYC3yinCNecBkqpSYrYZCBCZQG6BrWQNbb9ylDK+zOew/Oc+29AQ8rzxEi1tiQ==", "71543d6a-1393-4d69-95f5-fefa309a5562" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "021e9f57-0fee-4b5f-8597-ff32d727b8c2", new DateTime(2026, 1, 18, 12, 5, 7, 824, DateTimeKind.Utc).AddTicks(6863), "AQAAAAIAAYagAAAAEHq1G2ZBj+wDuHdfEBGpPItGI6RjmL4JXD0ZYjvTtrh/vI8EIquq8U8O1HdndhXYAA==", "3ba34bed-d244-4977-ac9b-88e2e2b365c2" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 1,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 12, 5, 7, 327, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 2,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 12, 5, 7, 327, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 3,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 12, 5, 7, 327, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 4,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 12, 5, 7, 327, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 5,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 12, 5, 7, 327, DateTimeKind.Utc).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewID",
                keyValue: 1,
                columns: new[] { "Date", "Description", "Rating", "ReviewTitle" },
                values: new object[] { new DateTime(2026, 1, 18, 20, 5, 7, 327, DateTimeKind.Local).AddTicks(1656), "Friendly staff and quick service. Will come again.", 4.5, "Excellent Service" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewID", "CustomerID", "Date", "Description", "Rating", "RestaurantID", "ReviewTitle", "Status" },
                values: new object[,]
                {
                    { 2, "8", new DateTime(2026, 1, 18, 20, 5, 7, 327, DateTimeKind.Local).AddTicks(1670), "Food was okay, but waiting time was a bit long.", 3.0, 2, "Average Experience", 0 },
                    { 3, "10", new DateTime(2026, 1, 18, 20, 5, 7, 327, DateTimeKind.Local).AddTicks(1672), "Food quality was great and portions were generous.", 4.0, 3, "Great Food", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a774b9c3-e3aa-48e1-b388-b3ff6a9ec638", new DateTime(2026, 1, 18, 7, 41, 43, 276, DateTimeKind.Utc).AddTicks(4925), "AQAAAAIAAYagAAAAEGB88B1Wkd16jLa+3o6tNZcLDJXLhEgmj2s7PIZBplq5yAtGtj0XVzcp0s71pW43vg==", "35420c24-2af1-4aad-b9c8-1970094ec6ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c97dfdc8-b855-486b-96e2-bc2dec192dfb", new DateTime(2026, 1, 18, 7, 41, 43, 878, DateTimeKind.Utc).AddTicks(8695), "AQAAAAIAAYagAAAAEMPJcjW0XPHd+gwUvDdPW2iM8Th1x1J+/j6PdeBKdpxpIeDlCfwXHT6yWryssoK0HA==", "83812eb9-bc33-4668-9247-a5c0d13b0f58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "465b25ab-1d83-4adc-b30f-da73b18b3078", new DateTime(2026, 1, 18, 7, 41, 43, 935, DateTimeKind.Utc).AddTicks(8098), "AQAAAAIAAYagAAAAELFA1pHpFRcZrW+cxHqS07IMAnnbcD1ZSGysH8ZqhtH5JpQYcgzpXYM9WkkqOjmjGg==", "9ddb5743-b0fc-4c2e-a826-284db3e9b088" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78049940-1b04-4965-890b-322d227a6833", new DateTime(2026, 1, 18, 7, 41, 43, 353, DateTimeKind.Utc).AddTicks(342), "AQAAAAIAAYagAAAAEE/VwB5piV8QuUBPxY5zNGcaJsEFE8eWxmaqzP3nhzF5twTJdJnKuu5EzMFzeV0Oiw==", "b24a3dd0-bb87-4d80-9517-ceacaa700f7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7be1ac42-5f6c-48ef-8a0f-22719a3c60c1", new DateTime(2026, 1, 18, 7, 41, 43, 410, DateTimeKind.Utc).AddTicks(6714), "AQAAAAIAAYagAAAAEI7N0M+UCa44ZH2xusz5pdsxDO0QEiMlwRwQp96pnzLhstGUlMtRHaCIf5eOKnpN/w==", "f1d519cc-7440-43e7-bc28-e3945fe9144f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b251a8a-0988-4fc0-9667-94db70e090a9", new DateTime(2026, 1, 18, 7, 41, 43, 489, DateTimeKind.Utc).AddTicks(1094), "AQAAAAIAAYagAAAAELFl+gx5pi5kc1QfyabZBe20uR9Gt3ggPq3jiiBYw5oo5eVn3uJMr2rptoDsRYYMVA==", "929f9231-6cf1-4e3a-8599-8b899974f106" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b933caf-b366-4e84-bd9e-73f94018d00e", new DateTime(2026, 1, 18, 7, 41, 43, 553, DateTimeKind.Utc).AddTicks(3531), "AQAAAAIAAYagAAAAEM9xOkrhbF1mlDHA4Ch7xGkzD2pD6GhVdpqi8I98NpBp80Q4HGLkhv8xas//HF28eA==", "bf8d272a-6e77-4965-987d-0b437bb08f02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da4eb4a7-c7c6-4c92-9243-df3008703d09", new DateTime(2026, 1, 18, 7, 41, 43, 619, DateTimeKind.Utc).AddTicks(4500), "AQAAAAIAAYagAAAAEG9LU66kIx6sxp32qx/PypLVkQZJPygprwaAuAglh4w2ku5x/DVxLVidFSIAh4dBAw==", "d13c23cc-f1da-444e-a7cf-9aea86eea29e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "925277f0-dfb3-447c-8243-7be3027b19a7", new DateTime(2026, 1, 18, 7, 41, 43, 703, DateTimeKind.Utc).AddTicks(7361), "AQAAAAIAAYagAAAAECtpJKqnQf3AiHVS+TgTeKmWHJ9WxngIF78CLxk4Li55mwmAe8RIwe3C3Yz5Cjr0dw==", "fe195352-b694-4303-b9af-e3dbe7fce800" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b57c5cb-8965-418b-9fa7-77a51b42c721", new DateTime(2026, 1, 18, 7, 41, 43, 760, DateTimeKind.Utc).AddTicks(6454), "AQAAAAIAAYagAAAAEBg1yQIX0p+6/JQCYsJ5IP4ohROWri10fGqrsutYNtpSyjVB081Gh2IWkWj6trOHow==", "9f9ad329-2dfb-4540-9054-adf7ac8e2a5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc31a5e8-72db-465a-b3e5-0a1cf787b30e", new DateTime(2026, 1, 18, 7, 41, 43, 820, DateTimeKind.Utc).AddTicks(2369), "AQAAAAIAAYagAAAAEA54BQGQ1ZixQfYBfdFCaLHb0prPo8wTCd6VPsoLqItjDaQCBfTEUf856PrSouCArA==", "39c16016-cd7a-4638-9e55-0a207bff435f" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 1,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 41, 43, 276, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 2,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 41, 43, 276, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 3,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 41, 43, 276, DateTimeKind.Utc).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 4,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 41, 43, 276, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 5,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 41, 43, 276, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewID",
                keyValue: 1,
                columns: new[] { "Date", "Description", "Rating", "ReviewTitle" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 41, 43, 276, DateTimeKind.Local).AddTicks(4621), "Bad", 2.5, "Bad" });
        }
    }
}
