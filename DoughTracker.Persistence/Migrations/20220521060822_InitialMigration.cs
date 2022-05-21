using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoughTracker.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    RoutingNumber = table.Column<int>(type: "int", nullable: false),
                    AccountTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Balance = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "varchar(20)", nullable: false),
                    SubcategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Frequency = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionID);
                });

            migrationBuilder.CreateTable(
                name: "TransactionSubcategory",
                columns: table => new
                {
                    SubcategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubcategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionSubcategory", x => x.SubcategoryID);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountID", "AccountNumber", "AccountTypeID", "Active", "Balance", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "RoutingNumber" },
                values: new object[,]
                {
                    { new Guid("26ae6ab0-77ce-4769-879a-368b0e9f50a2"), 1287518947, new Guid("2ff885b0-e66d-4cc1-9870-0a316dfaa912"), true, 1267.12m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Discover Checkings Account x2135", null, null, 31100649 },
                    { new Guid("8c8171c9-9e1d-45a5-a8dc-d72ed3f663cf"), -60528861, new Guid("b0c8492b-fb67-4e26-9841-c3e29a44e845"), true, 5812.64m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Discover Savings Account x2786", null, null, 31100649 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "SubcategoryID" },
                values: new object[,]
                {
                    { new Guid("18fef4c3-3599-4136-a133-a7fd2955b63a"), "Utilities", 38 },
                    { new Guid("cf6305ba-b753-4c07-9d42-364171e92b83"), "Utilities", 36 },
                    { new Guid("1327d335-1fae-4011-bf8a-0b63eacce293"), "Utilities", 35 },
                    { new Guid("ef086ccc-d6a9-40fd-b626-b27e5ee3843f"), "Utilities", 34 },
                    { new Guid("d5848a60-6b42-4ae4-9d54-eb67daf5e74f"), "Utilities", 33 },
                    { new Guid("2cf47a80-0c92-4aa6-8db3-40401fe863ab"), "Utilities", 32 },
                    { new Guid("18c4ce11-fcba-42e4-877b-a53589c339d2"), "Utilities", 31 },
                    { new Guid("86268ccc-6f56-4af9-9f61-5bb12ae9c947"), "Food", 24 },
                    { new Guid("d62aa78b-f0b7-49dc-a2a9-d93a82ba6363"), "Food", 23 },
                    { new Guid("9360d7da-9017-4c0a-afa5-81a1edf855fa"), "Food", 22 },
                    { new Guid("d45af9da-f49f-47bf-a2a8-aa6f8a78f3ea"), "Food", 21 },
                    { new Guid("f2d5480c-4ff7-4ca7-a40d-43fb6080f3a0"), "Transportation", 17 },
                    { new Guid("6bd1f3ab-448b-4ab9-8670-2be902bf17f2"), "Transportation", 16 },
                    { new Guid("de31fa20-97c0-4764-be13-bda7bc7e62ca"), "Utilities", 35 },
                    { new Guid("2d17e5f4-3c65-4f2d-a327-d7e1cee05a43"), "Transportation", 14 },
                    { new Guid("b40cecb1-2cc8-4f69-b9c5-f1e9c5891721"), "Transportation", 13 },
                    { new Guid("623b4a15-4438-43c9-9fb7-7ce07e23372a"), "Transportation", 12 },
                    { new Guid("8cfaac92-bf75-4270-a98f-3fd156c6847b"), "Transportation", 11 },
                    { new Guid("1335a07d-9c07-4065-a32b-d1f5320a9bc9"), "Transportation", 10 },
                    { new Guid("6b86a389-0f52-4db9-82cf-0e0ddbee987f"), "Housing", 5 },
                    { new Guid("e660279f-e2b8-439c-8f6e-b9f42a4b246c"), "Housing", 4 },
                    { new Guid("db9314d8-8420-4119-a3f9-1d50e2d706c5"), "Housing", 3 },
                    { new Guid("de66798e-b402-4c25-a112-51355c514236"), "Housing", 2 },
                    { new Guid("8c028c71-395c-4432-b92d-9b01ad6f5487"), "Housing", 1 },
                    { new Guid("366a8245-13af-4ab8-8dd5-d86af1829023"), "Transportation", 15 }
                });

            migrationBuilder.InsertData(
                table: "TransactionSubcategory",
                columns: new[] { "SubcategoryID", "SubcategoryName" },
                values: new object[,]
                {
                    { 21, "Groceries" },
                    { 22, "Restaurants" },
                    { 23, "Fast Food/Snacks" },
                    { 24, "Pet Food" },
                    { 35, "Sewage" },
                    { 32, "Gas" },
                    { 33, "Water" },
                    { 34, "Garbage" },
                    { 17, "Maintenance/Oil changes" },
                    { 36, "Phones" },
                    { 31, "Electricity" },
                    { 16, "Registration/DMV Fee" },
                    { 10, "Car Payment" },
                    { 14, "Parking Fees" },
                    { 13, "Tires" },
                    { 12, "Gas" },
                    { 11, "Car Warranty" },
                    { 5, "HOA Fees" },
                    { 4, "Household Repairs" },
                    { 3, "Property Taxes" },
                    { 2, "Rent" },
                    { 1, "Mortgage" },
                    { 37, "Cable" },
                    { 15, "Repairs" },
                    { 38, "Internet" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "AccountID", "Amount", "CategoryID", "CreatedBy", "CreatedDate", "Date", "Description", "Frequency", "LastModifiedBy", "LastModifiedDate", "Notes", "PaymentType", "Status", "TransactionType" },
                values: new object[,]
                {
                    { new Guid("f12b278e-76e8-4bbe-bb83-ef101dc04f16"), new Guid("26ae6ab0-77ce-4769-879a-368b0e9f50a2"), 1152.64m, new Guid("8c028c71-395c-4432-b92d-9b01ad6f5487"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monthly Mortage Payment", "Every 1st of the month", null, null, "", "Checkings Transfer", "Posted", "Expense" },
                    { new Guid("b1bffd63-698c-4d64-9421-b41fa5729c37"), new Guid("26ae6ab0-77ce-4769-879a-368b0e9f50a2"), 132.49m, new Guid("2cf47a80-0c92-4aa6-8db3-40401fe863ab"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oklahoma Natural Gas Bill", "Every 25th of the month", null, null, "", "Checkings Transfer", "Posted", "Expense" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "TransactionSubcategory");
        }
    }
}
