using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class IdentityAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.CreateTable(
            //     name: "AbpAuditLogs",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         BrowserInfo = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
            //         ClientIpAddress = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
            //         ClientName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
            //         CustomData = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
            //         Exception = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
            //         ExecutionDuration = table.Column<int>(type: "int", nullable: false),
            //         ExecutionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         ImpersonatorTenantId = table.Column<int>(type: "int", nullable: true),
            //         ImpersonatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         MethodName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //         Parameters = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
            //         ServiceName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         UserId = table.Column<long>(type: "bigint", nullable: true),
            //         ReturnValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ExceptionMessage = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpAuditLogs", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpBackgroundJobs",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         IsAbandoned = table.Column<bool>(type: "bit", nullable: false),
            //         JobArgs = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         JobType = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
            //         LastTryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         NextTryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Priority = table.Column<byte>(type: "tinyint", nullable: false),
            //         TryCount = table.Column<short>(type: "smallint", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpBackgroundJobs", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpDynamicProperties",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         PropertyName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //         InputType = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Permission = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpDynamicProperties", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpEditions",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
            //         DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         DisplayName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
            //         IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //         LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
            //         Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
            //         Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
            //         AnnualPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //         ExpiringEditionId = table.Column<int>(type: "int", nullable: true),
            //         MonthlyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //         TrialDayCount = table.Column<int>(type: "int", nullable: true),
            //         WaitingDayAfterExpire = table.Column<int>(type: "int", nullable: true),
            //         DailyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //         WeeklyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpEditions", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpEntityChangeSets",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         BrowserInfo = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
            //         ClientIpAddress = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
            //         ClientName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         ExtensionData = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ImpersonatorTenantId = table.Column<int>(type: "int", nullable: true),
            //         ImpersonatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         Reason = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         UserId = table.Column<long>(type: "bigint", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpEntityChangeSets", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpLanguages",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
            //         DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         DisplayName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
            //         Icon = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
            //         IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //         LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
            //         Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         IsDisabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpLanguages", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpLanguageTexts",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         Key = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
            //         LanguageName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //         LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
            //         Source = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpLanguageTexts", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpNotifications",
            //     columns: table => new
            //     {
            //         Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         DataTypeName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
            //         EntityId = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: true),
            //         EntityTypeAssemblyQualifiedName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
            //         EntityTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
            //         ExcludedUserIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         NotificationName = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: false),
            //         Severity = table.Column<byte>(type: "tinyint", nullable: false),
            //         TenantIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         UserIds = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpNotifications", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpNotificationSubscriptions",
            //     columns: table => new
            //     {
            //         Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         EntityId = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: true),
            //         EntityTypeAssemblyQualifiedName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
            //         EntityTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
            //         NotificationName = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: true),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         UserId = table.Column<long>(type: "bigint", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpNotificationSubscriptions", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpOrganizationUnitRoles",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         RoleId = table.Column<int>(type: "int", nullable: false),
            //         OrganizationUnitId = table.Column<long>(type: "bigint", nullable: false),
            //         IsDeleted = table.Column<bool>(type: "bit", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpOrganizationUnitRoles", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpOrganizationUnits",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Code = table.Column<string>(type: "nvarchar(95)", maxLength: 95, nullable: false),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
            //         DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         DisplayName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //         IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //         LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
            //         ParentId = table.Column<long>(type: "bigint", nullable: true),
            //         TenantId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpOrganizationUnits", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
            //             column: x => x.ParentId,
            //             principalTable: "AbpOrganizationUnits",
            //             principalColumn: "Id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpPersistedGrants",
            //     columns: table => new
            //     {
            //         Id = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //         ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //         Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //         ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //         SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpPersistedGrants", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpTenantNotifications",
            //     columns: table => new
            //     {
            //         Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         DataTypeName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
            //         EntityId = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: true),
            //         EntityTypeAssemblyQualifiedName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
            //         EntityTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
            //         NotificationName = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: false),
            //         Severity = table.Column<byte>(type: "tinyint", nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpTenantNotifications", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpUserAccounts",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
            //         DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         EmailAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //         IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //         LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         UserId = table.Column<long>(type: "bigint", nullable: false),
            //         UserLinkId = table.Column<long>(type: "bigint", nullable: true),
            //         UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpUserAccounts", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpUserLoginAttempts",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         BrowserInfo = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
            //         ClientIpAddress = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
            //         ClientName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Result = table.Column<byte>(type: "tinyint", nullable: false),
            //         TenancyName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         UserId = table.Column<long>(type: "bigint", nullable: true),
            //         UserNameOrEmailAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpUserLoginAttempts", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpUserNotifications",
            //     columns: table => new
            //     {
            //         Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         State = table.Column<int>(type: "int", nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         TenantNotificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //         UserId = table.Column<long>(type: "bigint", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpUserNotifications", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpUsers",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         AccessFailedCount = table.Column<int>(type: "int", nullable: false),
            //         AuthenticationSource = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
            //         ConcurrencyStamp = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
            //         DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         EmailAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
            //         EmailConfirmationCode = table.Column<string>(type: "nvarchar(328)", maxLength: 328, nullable: true),
            //         IsActive = table.Column<bool>(type: "bit", nullable: false),
            //         IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //         IsEmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
            //         IsLockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
            //         IsPhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
            //         IsTwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
            //         LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
            //         LockoutEndDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
            //         NormalizedEmailAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
            //         NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
            //         Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //         PasswordResetCode = table.Column<string>(type: "nvarchar(328)", maxLength: 328, nullable: true),
            //         PhoneNumber = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
            //         ProfilePictureId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //         SecurityStamp = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
            //         ShouldChangePasswordOnNextLogin = table.Column<bool>(type: "bit", nullable: false),
            //         Surname = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
            //         SignInToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         SignInTokenExpireTimeUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         GoogleAuthenticatorKey = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpUsers", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpUsers_AbpUsers_CreatorUserId",
            //             column: x => x.CreatorUserId,
            //             principalTable: "AbpUsers",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_AbpUsers_AbpUsers_DeleterUserId",
            //             column: x => x.DeleterUserId,
            //             principalTable: "AbpUsers",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_AbpUsers_AbpUsers_LastModifierUserId",
            //             column: x => x.LastModifierUserId,
            //             principalTable: "AbpUsers",
            //             principalColumn: "Id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpWebhookEvents",
            //     columns: table => new
            //     {
            //         Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //         WebhookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //         DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpWebhookEvents", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpWebhookSubscriptions",
            //     columns: table => new
            //     {
            //         Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         WebhookUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         Secret = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         IsActive = table.Column<bool>(type: "bit", nullable: false),
            //         Webhooks = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Headers = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpWebhookSubscriptions", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "accounts",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         created_on = table.Column<DateTime>(type: "datetime", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //         country = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
            //         location = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_accounts", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "alembic_version",
            //     columns: table => new
            //     {
            //         version_num = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("alembic_version_pkc", x => x.version_num);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AppBinaryObjects",
            //     columns: table => new
            //     {
            //         Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //         Bytes = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AppBinaryObjects", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AppChatMessages",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         ReadState = table.Column<int>(type: "int", nullable: false),
            //         Side = table.Column<int>(type: "int", nullable: false),
            //         TargetTenantId = table.Column<int>(type: "int", nullable: true),
            //         TargetUserId = table.Column<long>(type: "bigint", nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         UserId = table.Column<long>(type: "bigint", nullable: false),
            //         SharedMessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //         ReceiverReadState = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AppChatMessages", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AppFriendships",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         FriendProfilePictureId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //         FriendTenancyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         FriendTenantId = table.Column<int>(type: "int", nullable: true),
            //         FriendUserId = table.Column<long>(type: "bigint", nullable: false),
            //         FriendUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
            //         State = table.Column<int>(type: "int", nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         UserId = table.Column<long>(type: "bigint", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AppFriendships", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AppInvoices",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         TenantAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         TenantLegalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         TenantTaxNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AppInvoices", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AppSubscriptionPaymentsExtensionData",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         SubscriptionPaymentId = table.Column<long>(type: "bigint", nullable: false),
            //         Key = table.Column<string>(type: "nvarchar(450)", nullable: true),
            //         Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         IsDeleted = table.Column<bool>(type: "bit", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AppSubscriptionPaymentsExtensionData", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AppUserDelegations",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
            //         IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //         DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
            //         DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         SourceUserId = table.Column<long>(type: "bigint", nullable: false),
            //         TargetUserId = table.Column<long>(type: "bigint", nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AppUserDelegations", x => x.Id);
            //     });

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

            // migrationBuilder.CreateTable(
            //     name: "Brands",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //         Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //         Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Brands", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Competitions",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //         Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Competitions", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "DataSources",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         SourceName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //         SourceDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //         CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         LastProcessed = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_DataSources", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Markets",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //         Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Markets", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "ProductClassifications",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //         Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_ProductClassifications", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_amazon_search",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         DataSourceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ProductId = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         SourceUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawMention = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionDefaultLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RegionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MarketId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         KeyTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Recommendation = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Quantity = table.Column<int>(type: "int", nullable: true),
            //         Growth = table.Column<int>(type: "int", nullable: true),
            //         CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         item_id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
            //         name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false, defaultValueSql: "('')"),
            //         short_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         images = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         price = table.Column<double>(type: "float", nullable: true),
            //         average_rating = table.Column<double>(type: "float", nullable: true),
            //         number_of_reviews = table.Column<int>(type: "int", nullable: true),
            //         product_variants = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         product_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         link_to_all_reviews = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         product_information = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         reviews_by_rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         reviews_by_comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         search = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         product_id = table.Column<int>(type: "int", nullable: true),
            //         number_of_rating = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_amazon_search", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_bbb_search",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         DataSourceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ProductId = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         SourceUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawMention = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionDefaultLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RegionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MarketId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         KeyTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Recommendation = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Quantity = table.Column<int>(type: "int", nullable: true),
            //         Growth = table.Column<int>(type: "int", nullable: true),
            //         CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         bus_id = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
            //         url = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         businessStart = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         bbbFileOpened = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         incorporated = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         accredited = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         categories = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         isAccredited = table.Column<bool>(type: "bit", nullable: true),
            //         description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         yearsInBusiness = table.Column<int>(type: "int", nullable: true),
            //         typeOfEntity = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         num_of_reviews = table.Column<int>(type: "int", nullable: true),
            //         bbbRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         complaintTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         reviews = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         search = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         product_id = table.Column<int>(type: "int", nullable: true),
            //         location = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         country = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_bbb_search", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Products_bk",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //         ProductCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //         ProductDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //         CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         OwnedCompetition = table.Column<bool>(type: "bit", nullable: false),
            //         Amazon = table.Column<int>(type: "int", nullable: false),
            //         Angies = table.Column<int>(type: "int", nullable: false),
            //         Bbb = table.Column<int>(type: "int", nullable: false),
            //         Facebook = table.Column<int>(type: "int", nullable: false),
            //         FourSquare = table.Column<int>(type: "int", nullable: false),
            //         GoogleMyBusiness = table.Column<int>(type: "int", nullable: false),
            //         ImDb = table.Column<int>(type: "int", nullable: false),
            //         Manta = table.Column<int>(type: "int", nullable: false),
            //         TripAdvisor = table.Column<int>(type: "int", nullable: false),
            //         TrustPilot = table.Column<int>(type: "int", nullable: false),
            //         Twitter = table.Column<int>(type: "int", nullable: false),
            //         YelowPages = table.Column<int>(type: "int", nullable: false),
            //         Yelp = table.Column<int>(type: "int", nullable: false),
            //         ProductTypeId = table.Column<int>(type: "int", nullable: true),
            //         ProductClassificationId = table.Column<int>(type: "int", nullable: true),
            //         CompetitionId = table.Column<int>(type: "int", nullable: true),
            //         BrandId = table.Column<int>(type: "int", nullable: true),
            //         TopicCategoryId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_facebook_search",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         DataSourceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ProductId = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         SourceUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawMention = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionDefaultLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RegionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MarketId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         KeyTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Recommendation = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Quantity = table.Column<int>(type: "int", nullable: true),
            //         Growth = table.Column<int>(type: "int", nullable: true),
            //         CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         post_id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
            //         text = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false, defaultValueSql: "('')"),
            //         post_text = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         shared_text = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         time = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         image = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         images_lowquality = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         images = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         video = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         video_thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         video_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         likes = table.Column<int>(type: "int", nullable: true),
            //         comments = table.Column<int>(type: "int", nullable: true),
            //         shares = table.Column<int>(type: "int", nullable: true),
            //         post_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         link = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         user_id = table.Column<long>(type: "bigint", nullable: true),
            //         username = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         user_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         is_live = table.Column<bool>(type: "bit", nullable: true),
            //         factcheck = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         shared_post_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         shared_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         shared_user_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         shared_username = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         shared_post_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         available = table.Column<bool>(type: "bit", nullable: true),
            //         comments_full = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         reactors = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         reactions = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         w3_fb_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         location = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         country = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         search = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         product_id = table.Column<int>(type: "int", nullable: true),
            //         account = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_facebook_search", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_foursquare_search",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         DataSourceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ProductId = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         SourceUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawMention = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionDefaultLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RegionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MarketId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         KeyTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Recommendation = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Quantity = table.Column<int>(type: "int", nullable: true),
            //         Growth = table.Column<int>(type: "int", nullable: true),
            //         CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         bus_id = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
            //         name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         url = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         average_rating = table.Column<double>(type: "float", nullable: true),
            //         author = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         descrption = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         category = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         creation_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         num_of_reviews = table.Column<int>(type: "int", nullable: true),
            //         justification = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         tippets = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         features = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         varieties = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         reviews = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         search = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         product_id = table.Column<int>(type: "int", nullable: true),
            //         location = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         country = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_foursquare_search", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_imdb_search",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         DataSourceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ProductId = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         SourceUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawMention = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionDefaultLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RegionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MarketId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         KeyTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Recommendation = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Quantity = table.Column<int>(type: "int", nullable: true),
            //         Growth = table.Column<int>(type: "int", nullable: true),
            //         CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         movie_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
            //         url = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         date_published = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         content_rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         average_rating = table.Column<double>(type: "float", nullable: true),
            //         num_of_revies = table.Column<int>(type: "int", nullable: true),
            //         bestRating = table.Column<double>(type: "float", nullable: true),
            //         worstRating = table.Column<double>(type: "float", nullable: true),
            //         movie_duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         image = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         keywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         storyline = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         number_of_reviews = table.Column<int>(type: "int", nullable: true),
            //         number_of_critics = table.Column<int>(type: "int", nullable: true),
            //         director = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         writer = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         stars = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         popularity = table.Column<int>(type: "int", nullable: true),
            //         cast = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         reviews = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         country = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         search = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         product_id = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_imdb_search", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_manta_search",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         movie_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
            //         url = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         average_rating = table.Column<double>(type: "float", nullable: true),
            //         num_of_revies = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         movie_duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         movie_info = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         number_of_reviews = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         number_of_critics = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         popularity = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         cast = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         storyline = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         plot_keywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Genres = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         review_link = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         reviews = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         search = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         product_id = table.Column<int>(type: "int", nullable: true),
            //         CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         DataSourceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Growth = table.Column<int>(type: "int", nullable: true),
            //         KeyTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MarketId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionDefaultLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ProductId = table.Column<int>(type: "int", nullable: true),
            //         Quantity = table.Column<int>(type: "int", nullable: true),
            //         RawMention = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Recommendation = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RegionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         SourceUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_manta_search", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_trip_advisor_search",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         bizId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
            //         name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false, defaultValueSql: "('')"),
            //         description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         neighborhoods = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         businessUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         tags = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         url = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         image = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         priceRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         streetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         addressLocality = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         addressCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         addressRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         postalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         review = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         aggregate_rating_value = table.Column<double>(type: "float", nullable: true),
            //         aggregate_review_count = table.Column<int>(type: "int", nullable: true),
            //         categories = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         faq = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         search = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         product_id = table.Column<int>(type: "int", nullable: true),
            //         CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         DataSourceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Growth = table.Column<int>(type: "int", nullable: true),
            //         KeyTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MarketId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionDefaultLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ProductId = table.Column<int>(type: "int", nullable: true),
            //         Quantity = table.Column<int>(type: "int", nullable: true),
            //         RawMention = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Recommendation = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RegionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         SourceUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_trip_advisor_search", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_trust_pilot_search",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         DataSourceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ProductId = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         SourceUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawMention = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionDefaultLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RegionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MarketId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         KeyTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Recommendation = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Quantity = table.Column<int>(type: "int", nullable: true),
            //         Growth = table.Column<int>(type: "int", nullable: true),
            //         CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         bus_id = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
            //         name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         number_of_ratings = table.Column<int>(type: "int", nullable: true),
            //         number_of_reviews = table.Column<int>(type: "int", nullable: true),
            //         average_rating = table.Column<double>(type: "float", nullable: true),
            //         url = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         review_summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         reviews = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         image = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         worstRating = table.Column<int>(type: "int", nullable: true),
            //         bestRating = table.Column<int>(type: "int", nullable: true),
            //         addressCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         search = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         product_id = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_trust_pilot_search", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_twitter_search",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         DataSourceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ProductId = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         SourceUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawMention = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionDefaultLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RegionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MarketId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         KeyTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Recommendation = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Quantity = table.Column<int>(type: "int", nullable: true),
            //         Growth = table.Column<int>(type: "int", nullable: true),
            //         CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         tweet_id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
            //         conversation_id = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false, defaultValueSql: "('')"),
            //         created_at = table.Column<double>(type: "float", nullable: true),
            //         date = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         timezone = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         place = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         tweet = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         language = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         hashtags = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         cashtags = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         user_id = table.Column<long>(type: "bigint", nullable: true),
            //         user_id_str = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         username = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         day = table.Column<int>(type: "int", nullable: true),
            //         hour = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         link = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         urls = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         photos = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         video = table.Column<int>(type: "int", nullable: true),
            //         thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         retweet = table.Column<bool>(type: "bit", nullable: true),
            //         nlikes = table.Column<int>(type: "int", nullable: true),
            //         nreplies = table.Column<int>(type: "int", nullable: true),
            //         nretweets = table.Column<int>(type: "int", nullable: true),
            //         quote_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         search = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         near = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         geo = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         source = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         user_rt_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         user_rt = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         retweet_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         reply_to = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         retweet_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         translate = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         trans_src = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         trans_dest = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         location = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         country = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         product_id = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_twitter_search", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_yellow_pages_search",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         DataSourceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ProductId = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         SourceUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawMention = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionDefaultLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RegionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MarketId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         KeyTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Recommendation = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Quantity = table.Column<int>(type: "int", nullable: true),
            //         Growth = table.Column<int>(type: "int", nullable: true),
            //         CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         post_id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
            //         business_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false, defaultValueSql: "('')"),
            //         telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         business_page = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         rank = table.Column<int>(type: "int", nullable: true),
            //         category = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         website = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         number_of_reviews = table.Column<int>(type: "int", nullable: true),
            //         number_of_ratings = table.Column<int>(type: "int", nullable: true),
            //         address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         locality = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         region = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         zipcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         years_in_business = table.Column<int>(type: "int", nullable: true),
            //         description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         listing_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         reviews = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         business_info = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         country = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         search = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         product_id = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_yellow_pages_search", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_yelp_search",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         bizId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
            //         name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false, defaultValueSql: "('')"),
            //         description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         neighborhoods = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         businessUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         tags = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         url = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         image = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         priceRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         streetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         addressLocality = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         addressCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         addressRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         postalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         review = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         aggregate_rating_value = table.Column<double>(type: "float", nullable: true),
            //         aggregate_review_count = table.Column<int>(type: "int", nullable: true),
            //         categories = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         faq = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         search = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         product_id = table.Column<int>(type: "int", nullable: true),
            //         CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         DataSourceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Growth = table.Column<int>(type: "int", nullable: true),
            //         KeyTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MarketId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionDefaultLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OrganizationId1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ProductId = table.Column<int>(type: "int", nullable: true),
            //         Quantity = table.Column<int>(type: "int", nullable: true),
            //         RawMention = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Recommendation = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RegionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         SourceUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_yelp_search", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "ProductTypes",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //         Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_ProductTypes", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Regions",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //         Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Regions", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "TimePeriods",
            //     columns: table => new
            //     {
            //         DateKey = table.Column<int>(type: "int", nullable: false),
            //         FullDateAlternateKey = table.Column<DateTime>(type: "date", nullable: false),
            //         DayNumberOfWeek = table.Column<byte>(type: "tinyint", nullable: false),
            //         EnglishDayNameOfWeek = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
            //         SpanishDayNameOfWeek = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
            //         FrenchDayNameOfWeek = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
            //         DayNumberOfMonth = table.Column<byte>(type: "tinyint", nullable: false),
            //         DayNumberOfYear = table.Column<short>(type: "smallint", nullable: false),
            //         WeekNumberOfYear = table.Column<byte>(type: "tinyint", nullable: false),
            //         EnglishMonthName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
            //         SpanishMonthName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
            //         FrenchMonthName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
            //         MonthNumberOfYear = table.Column<byte>(type: "tinyint", nullable: false),
            //         CalendarQuarter = table.Column<byte>(type: "tinyint", nullable: false),
            //         CalendarYear = table.Column<short>(type: "smallint", nullable: false),
            //         CalendarSemester = table.Column<byte>(type: "tinyint", nullable: false),
            //         FiscalQuarter = table.Column<byte>(type: "tinyint", nullable: false),
            //         FiscalYear = table.Column<short>(type: "smallint", nullable: false),
            //         FiscalSemester = table.Column<byte>(type: "tinyint", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_TimePeriod_DateKey", x => x.DateKey);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "TopicCategories",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //         Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_TopicCategories", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpDynamicEntityProperties",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         EntityFullName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //         DynamicPropertyId = table.Column<int>(type: "int", nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpDynamicEntityProperties", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpDynamicEntityProperties_AbpDynamicProperties_DynamicPropertyId",
            //             column: x => x.DynamicPropertyId,
            //             principalTable: "AbpDynamicProperties",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpDynamicPropertyValues",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         DynamicPropertyId = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpDynamicPropertyValues", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpDynamicPropertyValues_AbpDynamicProperties_DynamicPropertyId",
            //             column: x => x.DynamicPropertyId,
            //             principalTable: "AbpDynamicProperties",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpFeatures",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //         Value = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
            //         EditionId = table.Column<int>(type: "int", nullable: true),
            //         TenantId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpFeatures", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpFeatures_AbpEditions_EditionId",
            //             column: x => x.EditionId,
            //             principalTable: "AbpEditions",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AppSubscriptionPayments",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         DayCount = table.Column<int>(type: "int", nullable: false),
            //         DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
            //         DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         EditionId = table.Column<int>(type: "int", nullable: false),
            //         Gateway = table.Column<int>(type: "int", nullable: false),
            //         IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //         LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
            //         SuccessUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         PaymentPeriodType = table.Column<int>(type: "int", nullable: true),
            //         Status = table.Column<int>(type: "int", nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: false),
            //         InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ErrorUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ExternalPaymentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
            //         IsRecurring = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
            //         EditionPaymentType = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AppSubscriptionPayments", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AppSubscriptionPayments_AbpEditions_EditionId",
            //             column: x => x.EditionId,
            //             principalTable: "AbpEditions",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpEntityChanges",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         ChangeTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         ChangeType = table.Column<byte>(type: "tinyint", nullable: false),
            //         EntityChangeSetId = table.Column<long>(type: "bigint", nullable: false),
            //         EntityId = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: true),
            //         EntityTypeFullName = table.Column<string>(type: "nvarchar(192)", maxLength: 192, nullable: true),
            //         TenantId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpEntityChanges", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpEntityChanges_AbpEntityChangeSets_EntityChangeSetId",
            //             column: x => x.EntityChangeSetId,
            //             principalTable: "AbpEntityChangeSets",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpRoles",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         ConcurrencyStamp = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
            //         DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         DisplayName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
            //         IsDefault = table.Column<bool>(type: "bit", nullable: false),
            //         IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //         IsStatic = table.Column<bool>(type: "bit", nullable: false),
            //         LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
            //         Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
            //         NormalizedName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpRoles", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpRoles_AbpUsers_CreatorUserId",
            //             column: x => x.CreatorUserId,
            //             principalTable: "AbpUsers",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_AbpRoles_AbpUsers_DeleterUserId",
            //             column: x => x.DeleterUserId,
            //             principalTable: "AbpUsers",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_AbpRoles_AbpUsers_LastModifierUserId",
            //             column: x => x.LastModifierUserId,
            //             principalTable: "AbpUsers",
            //             principalColumn: "Id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpSettings",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
            //         Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         UserId = table.Column<long>(type: "bigint", nullable: true),
            //         Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpSettings", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpSettings_AbpUsers_UserId",
            //             column: x => x.UserId,
            //             principalTable: "AbpUsers",
            //             principalColumn: "Id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpTenants",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         ConnectionString = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         CustomCssId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //         DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
            //         DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         EditionId = table.Column<int>(type: "int", nullable: true),
            //         IsActive = table.Column<bool>(type: "bit", nullable: false),
            //         IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //         LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
            //         LogoFileType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
            //         LogoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //         Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //         TenancyName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
            //         IsInTrialPeriod = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
            //         SubscriptionEndDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         SubscriptionPaymentType = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpTenants", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpTenants_AbpEditions_EditionId",
            //             column: x => x.EditionId,
            //             principalTable: "AbpEditions",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_AbpTenants_AbpUsers_CreatorUserId",
            //             column: x => x.CreatorUserId,
            //             principalTable: "AbpUsers",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_AbpTenants_AbpUsers_DeleterUserId",
            //             column: x => x.DeleterUserId,
            //             principalTable: "AbpUsers",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_AbpTenants_AbpUsers_LastModifierUserId",
            //             column: x => x.LastModifierUserId,
            //             principalTable: "AbpUsers",
            //             principalColumn: "Id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpUserClaims",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         ClaimType = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //         ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         UserId = table.Column<long>(type: "bigint", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpUserClaims", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpUserClaims_AbpUsers_UserId",
            //             column: x => x.UserId,
            //             principalTable: "AbpUsers",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpUserLogins",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //         ProviderKey = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         UserId = table.Column<long>(type: "bigint", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpUserLogins", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpUserLogins_AbpUsers_UserId",
            //             column: x => x.UserId,
            //             principalTable: "AbpUsers",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpUserOrganizationUnits",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         OrganizationUnitId = table.Column<long>(type: "bigint", nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         UserId = table.Column<long>(type: "bigint", nullable: false),
            //         IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpUserOrganizationUnits", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpUserOrganizationUnits_AbpUsers_UserId",
            //             column: x => x.UserId,
            //             principalTable: "AbpUsers",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpUserRoles",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         RoleId = table.Column<int>(type: "int", nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         UserId = table.Column<long>(type: "bigint", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpUserRoles", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpUserRoles_AbpUsers_UserId",
            //             column: x => x.UserId,
            //             principalTable: "AbpUsers",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpUserTokens",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
            //         Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         UserId = table.Column<long>(type: "bigint", nullable: false),
            //         Value = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
            //         ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpUserTokens", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpUserTokens_AbpUsers_UserId",
            //             column: x => x.UserId,
            //             principalTable: "AbpUsers",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpWebhookSendAttempts",
            //     columns: table => new
            //     {
            //         Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //         WebhookEventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //         WebhookSubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //         Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         ResponseStatusCode = table.Column<int>(type: "int", nullable: true),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         TenantId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpWebhookSendAttempts", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpWebhookSendAttempts_AbpWebhookEvents_WebhookEventId",
            //             column: x => x.WebhookEventId,
            //             principalTable: "AbpWebhookEvents",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

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

            // migrationBuilder.CreateTable(
            //     name: "products_amazon_reviews",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         user = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //         comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         reaction = table.Column<int>(type: "int", nullable: true),
            //         comment_rating = table.Column<double>(type: "float", nullable: true),
            //         amazon_id = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_amazon_reviews", x => x.id);
            //         table.ForeignKey(
            //             name: "fk_products_amazon_reviews_amazon_id_products_amazon_search",
            //             column: x => x.amazon_id,
            //             principalTable: "products_amazon_search",
            //             principalColumn: "id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_bbb_reviews",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         user = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //         comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         reaction = table.Column<int>(type: "int", nullable: true),
            //         comment_rating = table.Column<double>(type: "float", nullable: true),
            //         bbb_id = table.Column<int>(type: "int", nullable: false),
            //         date = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_bbb_reviews", x => x.id);
            //         table.ForeignKey(
            //             name: "fk_products_bbb_reviews_bbb_id_products_bbb_search",
            //             column: x => x.bbb_id,
            //             principalTable: "products_bbb_search",
            //             principalColumn: "id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_foursquare_reviews",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         user = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //         comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         down_vote = table.Column<double>(type: "float", nullable: true),
            //         up_vote = table.Column<double>(type: "float", nullable: true),
            //         date = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         user_justification = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         foursquare_id = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_foursquare_reviews", x => x.id);
            //         table.ForeignKey(
            //             name: "fk_products_foursquare_reviews_foursquare_id_products_foursquare_search",
            //             column: x => x.foursquare_id,
            //             principalTable: "products_foursquare_search",
            //             principalColumn: "id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_imdb_reviews",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         user = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //         date = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         rating = table.Column<int>(type: "int", nullable: true),
            //         title = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         reactions = table.Column<int>(type: "int", nullable: true),
            //         helpful = table.Column<int>(type: "int", nullable: true),
            //         imdb_id = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_imdb_reviews", x => x.id);
            //         table.ForeignKey(
            //             name: "fk_products_imdb_reviews_imdb_id_products_imdb_search",
            //             column: x => x.imdb_id,
            //             principalTable: "products_imdb_search",
            //             principalColumn: "id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_manta_reviews",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         user = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //         comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         reaction = table.Column<int>(type: "int", nullable: true),
            //         comment_rating = table.Column<double>(type: "float", nullable: true),
            //         manta_id = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_manta_reviews", x => x.id);
            //         table.ForeignKey(
            //             name: "fk_products_manta_reviews_manta_id_products_manta_search",
            //             column: x => x.manta_id,
            //             principalTable: "products_manta_search",
            //             principalColumn: "id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_trip_advisor_reviews",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         user = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //         comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         reaction = table.Column<int>(type: "int", nullable: true),
            //         comment_rating = table.Column<double>(type: "float", nullable: true),
            //         trip_advisor_id = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_trip_advisor_reviews", x => x.id);
            //         table.ForeignKey(
            //             name: "fk_products_trip_advisor_reviews_trip_advisor_id_products_trip_advisor_search",
            //             column: x => x.trip_advisor_id,
            //             principalTable: "products_trip_advisor_search",
            //             principalColumn: "id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_trust_pilot_reviews",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         user = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //         comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         location = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         title = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         date = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         comment_rating = table.Column<double>(type: "float", nullable: true),
            //         trust_pilot_id = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_trust_pilot_reviews", x => x.id);
            //         table.ForeignKey(
            //             name: "fk_products_trust_pilot_reviews_trust_pilot_id_products_trust_pilot_search",
            //             column: x => x.trust_pilot_id,
            //             principalTable: "products_trust_pilot_search",
            //             principalColumn: "id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_yellow_pages_reviews",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         user = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //         comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         title = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         date = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         comment_rating = table.Column<int>(type: "int", nullable: true),
            //         helpful = table.Column<int>(type: "int", nullable: true),
            //         yellow_pages_id = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_yellow_pages_reviews", x => x.id);
            //         table.ForeignKey(
            //             name: "fk_products_yellow_pages_reviews_yellow_pages_id_products_yellow_pages_search",
            //             column: x => x.yellow_pages_id,
            //             principalTable: "products_yellow_pages_search",
            //             principalColumn: "id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products_yelp_reviews",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         Sentiment = table.Column<int>(type: "int", nullable: true),
            //         created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         updated_on = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         is_active = table.Column<bool>(type: "bit", nullable: true),
            //         user = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //         comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         date = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         comment_rating = table.Column<int>(type: "int", nullable: true),
            //         helpful = table.Column<int>(type: "int", nullable: true),
            //         funny = table.Column<int>(type: "int", nullable: true),
            //         cool = table.Column<int>(type: "int", nullable: true),
            //         yelp_id = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products_yelp_reviews", x => x.id);
            //         table.ForeignKey(
            //             name: "fk_products_yelp_reviews_yelp_id_products_yelp_search",
            //             column: x => x.yelp_id,
            //             principalTable: "products_yelp_search",
            //             principalColumn: "id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Products",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //         ProductCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //         ProductDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //         CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         OwnedCompetition = table.Column<bool>(type: "bit", nullable: false),
            //         Amazon = table.Column<int>(type: "int", nullable: false),
            //         Angies = table.Column<int>(type: "int", nullable: false),
            //         Bbb = table.Column<int>(type: "int", nullable: false),
            //         Facebook = table.Column<int>(type: "int", nullable: false),
            //         FourSquare = table.Column<int>(type: "int", nullable: false),
            //         GoogleMyBusiness = table.Column<int>(type: "int", nullable: false),
            //         ImDb = table.Column<int>(type: "int", nullable: false),
            //         Manta = table.Column<int>(type: "int", nullable: false),
            //         TripAdvisor = table.Column<int>(type: "int", nullable: false),
            //         TrustPilot = table.Column<int>(type: "int", nullable: false),
            //         Twitter = table.Column<int>(type: "int", nullable: false),
            //         YelowPages = table.Column<int>(type: "int", nullable: false),
            //         Yelp = table.Column<int>(type: "int", nullable: false),
            //         ProductTypeId = table.Column<int>(type: "int", nullable: true),
            //         ProductClassificationId = table.Column<int>(type: "int", nullable: true),
            //         CompetitionId = table.Column<int>(type: "int", nullable: true),
            //         BrandId = table.Column<int>(type: "int", nullable: true),
            //         TopicCategoryId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Products", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_Products_Brands_BrandId",
            //             column: x => x.BrandId,
            //             principalTable: "Brands",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Products_Competitions_CompetitionId",
            //             column: x => x.CompetitionId,
            //             principalTable: "Competitions",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Products_ProductClassifications_ProductClassificationId",
            //             column: x => x.ProductClassificationId,
            //             principalTable: "ProductClassifications",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Products_ProductTypes_ProductTypeId",
            //             column: x => x.ProductTypeId,
            //             principalTable: "ProductTypes",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Products_TopicCategories_TopicCategoryId",
            //             column: x => x.TopicCategoryId,
            //             principalTable: "TopicCategories",
            //             principalColumn: "Id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "TopicLevel1",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         TopicLevelTerm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //         Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //         TopicLevelCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //         TopicCategoryId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_TopicLevel1", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_TopicLevel1_TopicCategories_TopicCategoryId",
            //             column: x => x.TopicCategoryId,
            //             principalTable: "TopicCategories",
            //             principalColumn: "Id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpDynamicEntityPropertyValues",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         EntityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         DynamicEntityPropertyId = table.Column<int>(type: "int", nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpDynamicEntityPropertyValues", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpDynamicEntityPropertyValues_AbpDynamicEntityProperties_DynamicEntityPropertyId",
            //             column: x => x.DynamicEntityPropertyId,
            //             principalTable: "AbpDynamicEntityProperties",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpEntityPropertyChanges",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         EntityChangeId = table.Column<long>(type: "bigint", nullable: false),
            //         NewValue = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
            //         OriginalValue = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
            //         PropertyName = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: true),
            //         PropertyTypeFullName = table.Column<string>(type: "nvarchar(192)", maxLength: 192, nullable: true),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         NewValueHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         OriginalValueHash = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpEntityPropertyChanges", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId",
            //             column: x => x.EntityChangeId,
            //             principalTable: "AbpEntityChanges",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpPermissions",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         IsGranted = table.Column<bool>(type: "bit", nullable: false),
            //         Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         RoleId = table.Column<int>(type: "int", nullable: true),
            //         UserId = table.Column<long>(type: "bigint", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpPermissions", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpPermissions_AbpRoles_RoleId",
            //             column: x => x.RoleId,
            //             principalTable: "AbpRoles",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //         table.ForeignKey(
            //             name: "FK_AbpPermissions_AbpUsers_UserId",
            //             column: x => x.UserId,
            //             principalTable: "AbpUsers",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "AbpRoleClaims",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         ClaimType = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //         ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
            //         RoleId = table.Column<int>(type: "int", nullable: false),
            //         TenantId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_AbpRoleClaims", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_AbpRoleClaims_AbpRoles_RoleId",
            //             column: x => x.RoleId,
            //             principalTable: "AbpRoles",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "TopicLevel2",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         TopicLevelTerm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //         Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //         TopicLevelCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicCategoryId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_TopicLevel2", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_TopicLevel2_TopicCategories_TopicCategoryId",
            //             column: x => x.TopicCategoryId,
            //             principalTable: "TopicCategories",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_TopicLevel2_TopicLevel1_TopicLevel1Id",
            //             column: x => x.TopicLevel1Id,
            //             principalTable: "TopicLevel1",
            //             principalColumn: "Id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "TopicLevel3",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TenantId = table.Column<int>(type: "int", nullable: true),
            //         TopicLevelTerm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //         Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //         TopicLevelCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //         TopicCategoryId = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_TopicLevel3", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_TopicLevel3_TopicCategories_TopicCategoryId",
            //             column: x => x.TopicCategoryId,
            //             principalTable: "TopicCategories",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_TopicLevel3_TopicLevel2_TopicLevel2Id",
            //             column: x => x.TopicLevel2Id,
            //             principalTable: "TopicLevel2",
            //             principalColumn: "Id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Mentions",
            //     columns: table => new
            //     {
            //         Id = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         SourceRowId = table.Column<long>(type: "bigint", nullable: true),
            //         RawSource = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //         SourceUserId = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
            //         MentionEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         RawMention = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         MentionDefaultLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Sentiment = table.Column<float>(type: "real", nullable: false),
            //         KeyTerms = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
            //         Recommendation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
            //         Quantity = table.Column<float>(type: "real", nullable: false),
            //         Growth = table.Column<float>(type: "real", nullable: false),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         DataSourceId = table.Column<int>(type: "int", nullable: true),
            //         ProductId = table.Column<int>(type: "int", nullable: true),
            //         LanguageId = table.Column<int>(type: "int", nullable: true),
            //         RegionId = table.Column<int>(type: "int", nullable: true),
            //         MarketId = table.Column<int>(type: "int", nullable: true),
            //         CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         DateKey = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Mentions", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_Mention_TimePeriod",
            //             column: x => x.DateKey,
            //             principalTable: "TimePeriods",
            //             principalColumn: "DateKey");
            //         table.ForeignKey(
            //             name: "FK_Mentions_AbpLanguages_LanguageId",
            //             column: x => x.LanguageId,
            //             principalTable: "AbpLanguages",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Mentions_DataSources_DataSourceId",
            //             column: x => x.DataSourceId,
            //             principalTable: "DataSources",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Mentions_Markets_MarketId",
            //             column: x => x.MarketId,
            //             principalTable: "Markets",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Mentions_Products_ProductId",
            //             column: x => x.ProductId,
            //             principalTable: "Products",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Mentions_Regions_RegionId",
            //             column: x => x.RegionId,
            //             principalTable: "Regions",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Mentions_TopicLevel1_TopicLevel1Id",
            //             column: x => x.TopicLevel1Id,
            //             principalTable: "TopicLevel1",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Mentions_TopicLevel2_TopicLevel2Id",
            //             column: x => x.TopicLevel2Id,
            //             principalTable: "TopicLevel2",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Mentions_TopicLevel3_TopicLevel3Id",
            //             column: x => x.TopicLevel3Id,
            //             principalTable: "TopicLevel3",
            //             principalColumn: "Id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Searches",
            //     columns: table => new
            //     {
            //         SearchId = table.Column<long>(type: "bigint", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         SourceRowId = table.Column<long>(type: "bigint", nullable: true),
            //         SearchTerm = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
            //         RawSearch = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Sentiment = table.Column<float>(type: "real", nullable: false),
            //         KeyTerms = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
            //         Volume = table.Column<float>(type: "real", nullable: false),
            //         Growth = table.Column<float>(type: "real", nullable: false),
            //         TopicLevel1Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel2Id = table.Column<int>(type: "int", nullable: true),
            //         TopicLevel3Id = table.Column<int>(type: "int", nullable: true),
            //         DataSourceId = table.Column<int>(type: "int", nullable: true),
            //         ProductId = table.Column<int>(type: "int", nullable: true),
            //         LanguageId = table.Column<int>(type: "int", nullable: true),
            //         RegionId = table.Column<int>(type: "int", nullable: true),
            //         MarketId = table.Column<int>(type: "int", nullable: true),
            //         CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //         UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //         DateKey = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Searches", x => x.SearchId);
            //         table.ForeignKey(
            //             name: "FK_Search_TimePeriod",
            //             column: x => x.DateKey,
            //             principalTable: "TimePeriods",
            //             principalColumn: "DateKey");
            //         table.ForeignKey(
            //             name: "FK_Searches_AbpLanguages_LanguageId",
            //             column: x => x.LanguageId,
            //             principalTable: "AbpLanguages",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Searches_DataSources_DataSourceId",
            //             column: x => x.DataSourceId,
            //             principalTable: "DataSources",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Searches_Markets_MarketId",
            //             column: x => x.MarketId,
            //             principalTable: "Markets",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Searches_Products_ProductId",
            //             column: x => x.ProductId,
            //             principalTable: "Products",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Searches_Regions_RegionId",
            //             column: x => x.RegionId,
            //             principalTable: "Regions",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Searches_TopicLevel1_TopicLevel1Id",
            //             column: x => x.TopicLevel1Id,
            //             principalTable: "TopicLevel1",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Searches_TopicLevel2_TopicLevel2Id",
            //             column: x => x.TopicLevel2Id,
            //             principalTable: "TopicLevel2",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "FK_Searches_TopicLevel3_TopicLevel3Id",
            //             column: x => x.TopicLevel3Id,
            //             principalTable: "TopicLevel3",
            //             principalColumn: "Id");
            //     });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09baff31-0f9a-48a8-ab7b-4b5b28b3a619", "7ab2361e-07bb-4f87-816e-f3f216756061", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd940d9b-ee25-4a66-a119-1953abbba4b5", "d54fe8c2-c813-4a53-a63a-5a2e30ffd81b", "Member", "MEMBER" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpAuditLogs_TenantId_ExecutionDuration",
            //     table: "AbpAuditLogs",
            //     columns: new[] { "TenantId", "ExecutionDuration" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpAuditLogs_TenantId_ExecutionTime",
            //     table: "AbpAuditLogs",
            //     columns: new[] { "TenantId", "ExecutionTime" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpAuditLogs_TenantId_UserId",
            //     table: "AbpAuditLogs",
            //     columns: new[] { "TenantId", "UserId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime",
            //     table: "AbpBackgroundJobs",
            //     columns: new[] { "IsAbandoned", "NextTryTime" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpDynamicEntityProperties_DynamicPropertyId",
            //     table: "AbpDynamicEntityProperties",
            //     column: "DynamicPropertyId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpDynamicEntityProperties_EntityFullName_DynamicPropertyId_TenantId",
            //     table: "AbpDynamicEntityProperties",
            //     columns: new[] { "EntityFullName", "DynamicPropertyId", "TenantId" },
            //     unique: true,
            //     filter: "([EntityFullName] IS NOT NULL AND [TenantId] IS NOT NULL)");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpDynamicEntityPropertyValues_DynamicEntityPropertyId",
            //     table: "AbpDynamicEntityPropertyValues",
            //     column: "DynamicEntityPropertyId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpDynamicProperties_PropertyName_TenantId",
            //     table: "AbpDynamicProperties",
            //     columns: new[] { "PropertyName", "TenantId" },
            //     unique: true,
            //     filter: "([PropertyName] IS NOT NULL AND [TenantId] IS NOT NULL)");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpDynamicPropertyValues_DynamicPropertyId",
            //     table: "AbpDynamicPropertyValues",
            //     column: "DynamicPropertyId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpEntityChanges_EntityChangeSetId",
            //     table: "AbpEntityChanges",
            //     column: "EntityChangeSetId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpEntityChanges_EntityTypeFullName_EntityId",
            //     table: "AbpEntityChanges",
            //     columns: new[] { "EntityTypeFullName", "EntityId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpEntityChangeSets_TenantId_CreationTime",
            //     table: "AbpEntityChangeSets",
            //     columns: new[] { "TenantId", "CreationTime" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpEntityChangeSets_TenantId_Reason",
            //     table: "AbpEntityChangeSets",
            //     columns: new[] { "TenantId", "Reason" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpEntityChangeSets_TenantId_UserId",
            //     table: "AbpEntityChangeSets",
            //     columns: new[] { "TenantId", "UserId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpEntityPropertyChanges_EntityChangeId",
            //     table: "AbpEntityPropertyChanges",
            //     column: "EntityChangeId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpFeatures_EditionId_Name",
            //     table: "AbpFeatures",
            //     columns: new[] { "EditionId", "Name" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpFeatures_TenantId_Name",
            //     table: "AbpFeatures",
            //     columns: new[] { "TenantId", "Name" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpLanguages_TenantId_Name",
            //     table: "AbpLanguages",
            //     columns: new[] { "TenantId", "Name" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpLanguageTexts_TenantId_Source_LanguageName_Key",
            //     table: "AbpLanguageTexts",
            //     columns: new[] { "TenantId", "Source", "LanguageName", "Key" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
            //     table: "AbpNotificationSubscriptions",
            //     columns: new[] { "NotificationName", "EntityTypeName", "EntityId", "UserId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
            //     table: "AbpNotificationSubscriptions",
            //     columns: new[] { "TenantId", "NotificationName", "EntityTypeName", "EntityId", "UserId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpOrganizationUnitRoles_TenantId_OrganizationUnitId",
            //     table: "AbpOrganizationUnitRoles",
            //     columns: new[] { "TenantId", "OrganizationUnitId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpOrganizationUnitRoles_TenantId_RoleId",
            //     table: "AbpOrganizationUnitRoles",
            //     columns: new[] { "TenantId", "RoleId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpOrganizationUnits_ParentId",
            //     table: "AbpOrganizationUnits",
            //     column: "ParentId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpOrganizationUnits_TenantId_Code",
            //     table: "AbpOrganizationUnits",
            //     columns: new[] { "TenantId", "Code" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpPermissions_RoleId",
            //     table: "AbpPermissions",
            //     column: "RoleId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpPermissions_TenantId_Name",
            //     table: "AbpPermissions",
            //     columns: new[] { "TenantId", "Name" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpPermissions_UserId",
            //     table: "AbpPermissions",
            //     column: "UserId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpPersistedGrants_Expiration",
            //     table: "AbpPersistedGrants",
            //     column: "Expiration");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpPersistedGrants_SubjectId_ClientId_Type",
            //     table: "AbpPersistedGrants",
            //     columns: new[] { "SubjectId", "ClientId", "Type" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpPersistedGrants_SubjectId_SessionId_Type",
            //     table: "AbpPersistedGrants",
            //     columns: new[] { "SubjectId", "SessionId", "Type" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpRoleClaims_RoleId",
            //     table: "AbpRoleClaims",
            //     column: "RoleId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpRoleClaims_TenantId_ClaimType",
            //     table: "AbpRoleClaims",
            //     columns: new[] { "TenantId", "ClaimType" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpRoles_CreatorUserId",
            //     table: "AbpRoles",
            //     column: "CreatorUserId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpRoles_DeleterUserId",
            //     table: "AbpRoles",
            //     column: "DeleterUserId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpRoles_LastModifierUserId",
            //     table: "AbpRoles",
            //     column: "LastModifierUserId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpRoles_TenantId_NormalizedName",
            //     table: "AbpRoles",
            //     columns: new[] { "TenantId", "NormalizedName" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpSettings_TenantId_Name_UserId",
            //     table: "AbpSettings",
            //     columns: new[] { "TenantId", "Name", "UserId" },
            //     unique: true,
            //     filter: "[TenantId] IS NOT NULL AND [Name] IS NOT NULL AND [UserId] IS NOT NULL");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpSettings_UserId",
            //     table: "AbpSettings",
            //     column: "UserId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpTenantNotifications_TenantId",
            //     table: "AbpTenantNotifications",
            //     column: "TenantId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpTenants_CreationTime",
            //     table: "AbpTenants",
            //     column: "CreationTime");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpTenants_CreatorUserId",
            //     table: "AbpTenants",
            //     column: "CreatorUserId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpTenants_DeleterUserId",
            //     table: "AbpTenants",
            //     column: "DeleterUserId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpTenants_EditionId",
            //     table: "AbpTenants",
            //     column: "EditionId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpTenants_LastModifierUserId",
            //     table: "AbpTenants",
            //     column: "LastModifierUserId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpTenants_SubscriptionEndDateUtc",
            //     table: "AbpTenants",
            //     column: "SubscriptionEndDateUtc");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpTenants_TenancyName",
            //     table: "AbpTenants",
            //     column: "TenancyName");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserAccounts_EmailAddress",
            //     table: "AbpUserAccounts",
            //     column: "EmailAddress");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserAccounts_TenantId_EmailAddress",
            //     table: "AbpUserAccounts",
            //     columns: new[] { "TenantId", "EmailAddress" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserAccounts_TenantId_UserId",
            //     table: "AbpUserAccounts",
            //     columns: new[] { "TenantId", "UserId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserAccounts_TenantId_UserName",
            //     table: "AbpUserAccounts",
            //     columns: new[] { "TenantId", "UserName" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserAccounts_UserName",
            //     table: "AbpUserAccounts",
            //     column: "UserName");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserClaims_TenantId_ClaimType",
            //     table: "AbpUserClaims",
            //     columns: new[] { "TenantId", "ClaimType" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserClaims_UserId",
            //     table: "AbpUserClaims",
            //     column: "UserId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result",
            //     table: "AbpUserLoginAttempts",
            //     columns: new[] { "TenancyName", "UserNameOrEmailAddress", "Result" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserLoginAttempts_UserId_TenantId",
            //     table: "AbpUserLoginAttempts",
            //     columns: new[] { "UserId", "TenantId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserLogins_TenantId_LoginProvider_ProviderKey",
            //     table: "AbpUserLogins",
            //     columns: new[] { "TenantId", "LoginProvider", "ProviderKey" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserLogins_TenantId_UserId",
            //     table: "AbpUserLogins",
            //     columns: new[] { "TenantId", "UserId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserLogins_UserId",
            //     table: "AbpUserLogins",
            //     column: "UserId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserNotifications_UserId_State_CreationTime",
            //     table: "AbpUserNotifications",
            //     columns: new[] { "UserId", "State", "CreationTime" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserOrganizationUnits_TenantId_OrganizationUnitId",
            //     table: "AbpUserOrganizationUnits",
            //     columns: new[] { "TenantId", "OrganizationUnitId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserOrganizationUnits_TenantId_UserId",
            //     table: "AbpUserOrganizationUnits",
            //     columns: new[] { "TenantId", "UserId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserOrganizationUnits_UserId",
            //     table: "AbpUserOrganizationUnits",
            //     column: "UserId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserRoles_TenantId_RoleId",
            //     table: "AbpUserRoles",
            //     columns: new[] { "TenantId", "RoleId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserRoles_TenantId_UserId",
            //     table: "AbpUserRoles",
            //     columns: new[] { "TenantId", "UserId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserRoles_UserId",
            //     table: "AbpUserRoles",
            //     column: "UserId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUsers_CreatorUserId",
            //     table: "AbpUsers",
            //     column: "CreatorUserId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUsers_DeleterUserId",
            //     table: "AbpUsers",
            //     column: "DeleterUserId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUsers_LastModifierUserId",
            //     table: "AbpUsers",
            //     column: "LastModifierUserId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUsers_TenantId_NormalizedEmailAddress",
            //     table: "AbpUsers",
            //     columns: new[] { "TenantId", "NormalizedEmailAddress" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUsers_TenantId_NormalizedUserName",
            //     table: "AbpUsers",
            //     columns: new[] { "TenantId", "NormalizedUserName" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserTokens_TenantId_UserId",
            //     table: "AbpUserTokens",
            //     columns: new[] { "TenantId", "UserId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpUserTokens_UserId",
            //     table: "AbpUserTokens",
            //     column: "UserId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AbpWebhookSendAttempts_WebhookEventId",
            //     table: "AbpWebhookSendAttempts",
            //     column: "WebhookEventId");

            // migrationBuilder.CreateIndex(
            //     name: "uq_accounts_name",
            //     table: "accounts",
            //     column: "name",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "IX_AppBinaryObjects_TenantId",
            //     table: "AppBinaryObjects",
            //     column: "TenantId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AppChatMessages_TargetTenantId_TargetUserId_ReadState",
            //     table: "AppChatMessages",
            //     columns: new[] { "TargetTenantId", "TargetUserId", "ReadState" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AppChatMessages_TargetTenantId_UserId_ReadState",
            //     table: "AppChatMessages",
            //     columns: new[] { "TargetTenantId", "UserId", "ReadState" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AppChatMessages_TenantId_TargetUserId_ReadState",
            //     table: "AppChatMessages",
            //     columns: new[] { "TenantId", "TargetUserId", "ReadState" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AppChatMessages_TenantId_UserId_ReadState",
            //     table: "AppChatMessages",
            //     columns: new[] { "TenantId", "UserId", "ReadState" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AppFriendships_FriendTenantId_FriendUserId",
            //     table: "AppFriendships",
            //     columns: new[] { "FriendTenantId", "FriendUserId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AppFriendships_FriendTenantId_UserId",
            //     table: "AppFriendships",
            //     columns: new[] { "FriendTenantId", "UserId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AppFriendships_TenantId_FriendUserId",
            //     table: "AppFriendships",
            //     columns: new[] { "TenantId", "FriendUserId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AppFriendships_TenantId_UserId",
            //     table: "AppFriendships",
            //     columns: new[] { "TenantId", "UserId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AppSubscriptionPayments_EditionId",
            //     table: "AppSubscriptionPayments",
            //     column: "EditionId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AppSubscriptionPayments_ExternalPaymentId_Gateway",
            //     table: "AppSubscriptionPayments",
            //     columns: new[] { "ExternalPaymentId", "Gateway" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AppSubscriptionPayments_Status_CreationTime",
            //     table: "AppSubscriptionPayments",
            //     columns: new[] { "Status", "CreationTime" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AppSubscriptionPaymentsExtensionData_SubscriptionPaymentId_Key_IsDeleted",
            //     table: "AppSubscriptionPaymentsExtensionData",
            //     columns: new[] { "SubscriptionPaymentId", "Key", "IsDeleted" },
            //     unique: true,
            //     filter: "([Key] IS NOT NULL)");

            // migrationBuilder.CreateIndex(
            //     name: "IX_AppUserDelegations_TenantId_SourceUserId",
            //     table: "AppUserDelegations",
            //     columns: new[] { "TenantId", "SourceUserId" });

            // migrationBuilder.CreateIndex(
            //     name: "IX_AppUserDelegations_TenantId_TargetUserId",
            //     table: "AppUserDelegations",
            //     columns: new[] { "TenantId", "TargetUserId" });

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

            // migrationBuilder.CreateIndex(
            //     name: "IX_Brands_TenantId",
            //     table: "Brands",
            //     column: "TenantId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Competitions_TenantId",
            //     table: "Competitions",
            //     column: "TenantId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_DataSources_TenantId",
            //     table: "DataSources",
            //     column: "TenantId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Markets_TenantId",
            //     table: "Markets",
            //     column: "TenantId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Mentions_DataSourceId",
            //     table: "Mentions",
            //     column: "DataSourceId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Mentions_DateKey",
            //     table: "Mentions",
            //     column: "DateKey");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Mentions_LanguageId",
            //     table: "Mentions",
            //     column: "LanguageId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Mentions_MarketId",
            //     table: "Mentions",
            //     column: "MarketId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Mentions_ProductId",
            //     table: "Mentions",
            //     column: "ProductId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Mentions_RegionId",
            //     table: "Mentions",
            //     column: "RegionId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Mentions_TopicLevel1Id",
            //     table: "Mentions",
            //     column: "TopicLevel1Id");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Mentions_TopicLevel2Id",
            //     table: "Mentions",
            //     column: "TopicLevel2Id");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Mentions_TopicLevel3Id",
            //     table: "Mentions",
            //     column: "TopicLevel3Id");

            // migrationBuilder.CreateIndex(
            //     name: "IX_ProductClassifications_TenantId",
            //     table: "ProductClassifications",
            //     column: "TenantId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Products_BrandId",
            //     table: "Products",
            //     column: "BrandId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Products_CompetitionId",
            //     table: "Products",
            //     column: "CompetitionId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Products_ProductClassificationId",
            //     table: "Products",
            //     column: "ProductClassificationId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Products_ProductTypeId",
            //     table: "Products",
            //     column: "ProductTypeId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Products_TenantId",
            //     table: "Products",
            //     column: "TenantId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Products_TopicCategoryId",
            //     table: "Products",
            //     column: "TopicCategoryId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_products_amazon_reviews_amazon_id",
            //     table: "products_amazon_reviews",
            //     column: "amazon_id");

            // migrationBuilder.CreateIndex(
            //     name: "uq_products_amazon_search_item_id",
            //     table: "products_amazon_search",
            //     column: "item_id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "IX_products_bbb_reviews_bbb_id",
            //     table: "products_bbb_reviews",
            //     column: "bbb_id");

            // migrationBuilder.CreateIndex(
            //     name: "uq_products_bbb_search_bus_id",
            //     table: "products_bbb_search",
            //     column: "bus_id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "uq_products_facebook_search_post_id",
            //     table: "products_facebook_search",
            //     column: "post_id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "IX_products_foursquare_reviews_foursquare_id",
            //     table: "products_foursquare_reviews",
            //     column: "foursquare_id");

            // migrationBuilder.CreateIndex(
            //     name: "uq_products_foursquare_search_bus_id",
            //     table: "products_foursquare_search",
            //     column: "bus_id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "IX_products_imdb_reviews_imdb_id",
            //     table: "products_imdb_reviews",
            //     column: "imdb_id");

            // migrationBuilder.CreateIndex(
            //     name: "uq_products_imdb_search_title",
            //     table: "products_imdb_search",
            //     column: "title",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "IX_products_manta_reviews_manta_id",
            //     table: "products_manta_reviews",
            //     column: "manta_id");

            // migrationBuilder.CreateIndex(
            //     name: "uq_products_manta_search_title",
            //     table: "products_manta_search",
            //     column: "title",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "IX_products_trip_advisor_reviews_trip_advisor_id",
            //     table: "products_trip_advisor_reviews",
            //     column: "trip_advisor_id");

            // migrationBuilder.CreateIndex(
            //     name: "uq_products_trip_advisor_search_bizId",
            //     table: "products_trip_advisor_search",
            //     column: "bizId",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "IX_products_trust_pilot_reviews_trust_pilot_id",
            //     table: "products_trust_pilot_reviews",
            //     column: "trust_pilot_id");

            // migrationBuilder.CreateIndex(
            //     name: "uq_products_trust_pilot_search_bus_id",
            //     table: "products_trust_pilot_search",
            //     column: "bus_id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "uq_products_twitter_search_tweet_id",
            //     table: "products_twitter_search",
            //     column: "tweet_id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "IX_products_yellow_pages_reviews_yellow_pages_id",
            //     table: "products_yellow_pages_reviews",
            //     column: "yellow_pages_id");

            // migrationBuilder.CreateIndex(
            //     name: "uq_products_yellow_pages_search_post_id",
            //     table: "products_yellow_pages_search",
            //     column: "post_id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "IX_products_yelp_reviews_yelp_id",
            //     table: "products_yelp_reviews",
            //     column: "yelp_id");

            // migrationBuilder.CreateIndex(
            //     name: "uq_products_yelp_search_bizId",
            //     table: "products_yelp_search",
            //     column: "bizId",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "IX_ProductTypes_TenantId",
            //     table: "ProductTypes",
            //     column: "TenantId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Regions_TenantId",
            //     table: "Regions",
            //     column: "TenantId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Searches_DataSourceId",
            //     table: "Searches",
            //     column: "DataSourceId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Searches_DateKey",
            //     table: "Searches",
            //     column: "DateKey");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Searches_LanguageId",
            //     table: "Searches",
            //     column: "LanguageId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Searches_MarketId",
            //     table: "Searches",
            //     column: "MarketId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Searches_ProductId",
            //     table: "Searches",
            //     column: "ProductId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Searches_RegionId",
            //     table: "Searches",
            //     column: "RegionId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Searches_TopicLevel1Id",
            //     table: "Searches",
            //     column: "TopicLevel1Id");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Searches_TopicLevel2Id",
            //     table: "Searches",
            //     column: "TopicLevel2Id");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Searches_TopicLevel3Id",
            //     table: "Searches",
            //     column: "TopicLevel3Id");

            // migrationBuilder.CreateIndex(
            //     name: "AK_TimePeriod_FullDateAlternateKey",
            //     table: "TimePeriods",
            //     column: "FullDateAlternateKey",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "IX_TopicCategories_TenantId",
            //     table: "TopicCategories",
            //     column: "TenantId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_TopicLevel1_TenantId",
            //     table: "TopicLevel1",
            //     column: "TenantId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_TopicLevel1_TopicCategoryId",
            //     table: "TopicLevel1",
            //     column: "TopicCategoryId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_TopicLevel2_TenantId",
            //     table: "TopicLevel2",
            //     column: "TenantId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_TopicLevel2_TopicCategoryId",
            //     table: "TopicLevel2",
            //     column: "TopicCategoryId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_TopicLevel2_TopicLevel1Id",
            //     table: "TopicLevel2",
            //     column: "TopicLevel1Id");

            // migrationBuilder.CreateIndex(
            //     name: "IX_TopicLevel3_TenantId",
            //     table: "TopicLevel3",
            //     column: "TenantId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_TopicLevel3_TopicCategoryId",
            //     table: "TopicLevel3",
            //     column: "TopicCategoryId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_TopicLevel3_TopicLevel2Id",
            //     table: "TopicLevel3",
            //     column: "TopicLevel2Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbpAuditLogs");

            migrationBuilder.DropTable(
                name: "AbpBackgroundJobs");

            migrationBuilder.DropTable(
                name: "AbpDynamicEntityPropertyValues");

            migrationBuilder.DropTable(
                name: "AbpDynamicPropertyValues");

            migrationBuilder.DropTable(
                name: "AbpEntityPropertyChanges");

            migrationBuilder.DropTable(
                name: "AbpFeatures");

            migrationBuilder.DropTable(
                name: "AbpLanguageTexts");

            migrationBuilder.DropTable(
                name: "AbpNotifications");

            migrationBuilder.DropTable(
                name: "AbpNotificationSubscriptions");

            migrationBuilder.DropTable(
                name: "AbpOrganizationUnitRoles");

            migrationBuilder.DropTable(
                name: "AbpOrganizationUnits");

            migrationBuilder.DropTable(
                name: "AbpPermissions");

            migrationBuilder.DropTable(
                name: "AbpPersistedGrants");

            migrationBuilder.DropTable(
                name: "AbpRoleClaims");

            migrationBuilder.DropTable(
                name: "AbpSettings");

            migrationBuilder.DropTable(
                name: "AbpTenantNotifications");

            migrationBuilder.DropTable(
                name: "AbpTenants");

            migrationBuilder.DropTable(
                name: "AbpUserAccounts");

            migrationBuilder.DropTable(
                name: "AbpUserClaims");

            migrationBuilder.DropTable(
                name: "AbpUserLoginAttempts");

            migrationBuilder.DropTable(
                name: "AbpUserLogins");

            migrationBuilder.DropTable(
                name: "AbpUserNotifications");

            migrationBuilder.DropTable(
                name: "AbpUserOrganizationUnits");

            migrationBuilder.DropTable(
                name: "AbpUserRoles");

            migrationBuilder.DropTable(
                name: "AbpUserTokens");

            migrationBuilder.DropTable(
                name: "AbpWebhookSendAttempts");

            migrationBuilder.DropTable(
                name: "AbpWebhookSubscriptions");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "alembic_version");

            migrationBuilder.DropTable(
                name: "AppBinaryObjects");

            migrationBuilder.DropTable(
                name: "AppChatMessages");

            migrationBuilder.DropTable(
                name: "AppFriendships");

            migrationBuilder.DropTable(
                name: "AppInvoices");

            migrationBuilder.DropTable(
                name: "AppSubscriptionPayments");

            migrationBuilder.DropTable(
                name: "AppSubscriptionPaymentsExtensionData");

            migrationBuilder.DropTable(
                name: "AppUserDelegations");

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
                name: "Mentions");

            migrationBuilder.DropTable(
                name: "products_amazon_reviews");

            migrationBuilder.DropTable(
                name: "products_bbb_reviews");

            migrationBuilder.DropTable(
                name: "Products_bk");

            migrationBuilder.DropTable(
                name: "products_facebook_search");

            migrationBuilder.DropTable(
                name: "products_foursquare_reviews");

            migrationBuilder.DropTable(
                name: "products_imdb_reviews");

            migrationBuilder.DropTable(
                name: "products_manta_reviews");

            migrationBuilder.DropTable(
                name: "products_trip_advisor_reviews");

            migrationBuilder.DropTable(
                name: "products_trust_pilot_reviews");

            migrationBuilder.DropTable(
                name: "products_twitter_search");

            migrationBuilder.DropTable(
                name: "products_yellow_pages_reviews");

            migrationBuilder.DropTable(
                name: "products_yelp_reviews");

            migrationBuilder.DropTable(
                name: "Searches");

            migrationBuilder.DropTable(
                name: "AbpDynamicEntityProperties");

            migrationBuilder.DropTable(
                name: "AbpEntityChanges");

            migrationBuilder.DropTable(
                name: "AbpRoles");

            migrationBuilder.DropTable(
                name: "AbpWebhookEvents");

            migrationBuilder.DropTable(
                name: "AbpEditions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "products_amazon_search");

            migrationBuilder.DropTable(
                name: "products_bbb_search");

            migrationBuilder.DropTable(
                name: "products_foursquare_search");

            migrationBuilder.DropTable(
                name: "products_imdb_search");

            migrationBuilder.DropTable(
                name: "products_manta_search");

            migrationBuilder.DropTable(
                name: "products_trip_advisor_search");

            migrationBuilder.DropTable(
                name: "products_trust_pilot_search");

            migrationBuilder.DropTable(
                name: "products_yellow_pages_search");

            migrationBuilder.DropTable(
                name: "products_yelp_search");

            migrationBuilder.DropTable(
                name: "TimePeriods");

            migrationBuilder.DropTable(
                name: "AbpLanguages");

            migrationBuilder.DropTable(
                name: "DataSources");

            migrationBuilder.DropTable(
                name: "Markets");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "TopicLevel3");

            migrationBuilder.DropTable(
                name: "AbpDynamicProperties");

            migrationBuilder.DropTable(
                name: "AbpEntityChangeSets");

            migrationBuilder.DropTable(
                name: "AbpUsers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "ProductClassifications");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "TopicLevel2");

            migrationBuilder.DropTable(
                name: "TopicLevel1");

            migrationBuilder.DropTable(
                name: "TopicCategories");
        }
    }
}
