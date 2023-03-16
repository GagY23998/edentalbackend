using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalOffice.Entities.Migrations
{
    /// <inheritdoc />
    public partial class newMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsNotificationEnabled",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsNotificationEnabled", "PasswordHash", "PasswordSalt" },
                values: new object[] { false, "9nVuU/1qpa49B6VzyC7X0jGdoZw=", "nyPULv08kGJ1B/ai4phn+w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsNotificationEnabled", "PasswordHash", "PasswordSalt" },
                values: new object[] { false, "cyzTOs8cCOR6TTczN4eo47nmef0=", "B2BqkH7MvhjwUJXQnUo3rA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsNotificationEnabled", "PasswordHash", "PasswordSalt" },
                values: new object[] { false, "9I1mOOtvtCOW7lTwGYVMEm6h3O0=", "mIWeEp1lD5NddxnBT4ucSw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsNotificationEnabled", "PasswordHash", "PasswordSalt" },
                values: new object[] { false, "tkq+wBc0oyEXHh1jCy2uZ4x+SUc=", "RUv1pK2SqVbaUqL/MA5rJQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNotificationEnabled",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "5Ik9k8Z142fLbqCw2eqDARmBB2w=", "7H07YqXBcVLy0xgoCrduAQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "PWMfE9ResmXdhv+/mMp/rLXP2c0=", "1j+1HLVnG7c+ozLvAAnGrg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "fgQTwaMsy9uY8LTXzF0JW4rc6V8=", "vi4qCRDl5Zn9PTvEjfzWbg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "sWQvcsfCT0X52Yx4c4Nw4rEc3wA=", "tHJ9wvNWjkuADfdUBYLYWw==" });
        }
    }
}
