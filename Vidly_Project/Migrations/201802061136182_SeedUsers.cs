namespace Vidly_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8e1e518e-15ac-4f33-aa6a-6975821bb06d', N'admin@vidly.com', 0, N'AHsCeN3WmcvIay/DoEO+zOfxyCaIcJHd5/aVI8vzkapJ87jwZBUKbpR1qstC8GJRdg==', N'7e820bc1-ad1b-490c-8c44-8369a1044386', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9dbdf471-1315-4235-87a2-5a9a92468707', N'guest@vidly.com', 0, N'ANEBjoaKvrl1z+G6W5/Vzl65Ogr1gQcziFde+9J0lFMolI0u7np8YBZfCbvjTBJKfA==', N'a3338245-1538-4602-9629-49368f6e1c80', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')");
            Sql("INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'71123d4d-0da2-4c80-8ea2-50337df887d2', N'CanManageMovies')");
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8e1e518e-15ac-4f33-aa6a-6975821bb06d', N'71123d4d-0da2-4c80-8ea2-50337df887d2')");
        }
        
        public override void Down()
        {
        }
    }
}
