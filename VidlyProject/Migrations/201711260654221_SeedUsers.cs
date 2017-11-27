namespace VidlyProject.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c48b5276-9133-47eb-9418-d6804b2935de', N'admin@vidly.com', 0, N'AO/UAaRkJl7ez0Nck4dcXQvddtQcqXfuNmqy7FaTcB1ClyZA5d7OlmfaBt9n/Aa9iA==', N'173bd97d-577b-4d83-9eab-ffa1f086eae1', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dab852d1-61ed-40a4-b184-accf273e5bcc', N'guest@vidly.com', 0, N'AE/vFNq/duDC+5CVCBvVRHgddrmuT67FmsT5OctJYsaji35Bt0xhynRY4rE/M+rcqg==', N'6abe9b33-a99b-4e12-b727-2e40e833ad4d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4c4d67d5-8f31-4624-92f2-7e02f5158862', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c48b5276-9133-47eb-9418-d6804b2935de', N'4c4d67d5-8f31-4624-92f2-7e02f5158862')
");
        }

        public override void Down()
        {
        }
    }
}