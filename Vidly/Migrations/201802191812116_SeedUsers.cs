namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'63d4debd-178d-4358-826e-670e157dfec4', N'admin@mr.com', 0, N'AMVKAQ54Tb9diAX6cGiL4ewIuouEedQHdvGezCX+mIRnsg8i2HW01BR++Gn8dZVazg==', N'745942fe-d8cd-43bb-be58-cb5da5b728c0', NULL, 0, 0, NULL, 1, 0, N'admin@mr.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'721d392b-e4a3-44ed-87de-deb9d8fb5a2a', N'guest@r.com', 0, N'AAznZDTNwTx4C8Cg/w+B5OHhV50D6VyRIjKjbIxhK9xM3kwuFvOx9RJTnQsZx+aBzg==', N'f35ea28e-df87-4bec-9f7d-b0002eed32e3', NULL, 0, 0, NULL, 1, 0, N'guest@r.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fa9d9006-bf13-4d6c-9dfe-2dd78cc12410', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'63d4debd-178d-4358-826e-670e157dfec4', N'fa9d9006-bf13-4d6c-9dfe-2dd78cc12410')
                ");
        }

        public override void Down()
        {
        }
    }
}
