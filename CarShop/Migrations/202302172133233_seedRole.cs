namespace CarShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedRole : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'209c0771-fc72-4e80-bc31-75daf2851c27', N'admin@cars.com', 0, N'AFI979Nkjz1qq6cJImUHdxgEtOAbu5cqbUSyZy6Xr9I2LARo7+TdhALKU4LDcGI3QQ==', N'0c48b41a-cbff-4dab-838b-fb369eb60af4', NULL, 0, 0, NULL, 1, 0, N'admin@cars.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c8e1f4e4-27c4-4fc2-befc-c890b831f7c7', N'Example@gmail.com', 0, N'ABSUjzU0wa3HGmaHcmH9KtfIcKu/1RZF60ZVajfHCoyVUqrxpy6Af34+TNiBPmOO5g==', N'c021e55a-65cc-4270-9d71-7df89416f95b', NULL, 0, 0, NULL, 1, 0, N'Example@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'48003be7-35c3-4642-8c4d-b66815b0ee31', N'CanManageCars')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'209c0771-fc72-4e80-bc31-75daf2851c27', N'48003be7-35c3-4642-8c4d-b66815b0ee31')

");
        }    
        public override void Down()
        {

        }
    }
}
