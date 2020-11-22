namespace DesafioFiap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAdminUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) 
                VALUES (N'40366ecb-3776-4618-b7a1-74d63d7b3d06', N'admin@gmail.com', 0, N'ADQHRXjqJOnhQ2WX7bnsFaSZ2o1bowb2M8j9ia9sQweDMFEHGjyco4IUiNGtU4e+5g==', N'fe552141-b66d-47ac-80b4-b8306752b4d5', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com');
                "
            );
        }
        
        public override void Down()
        {
        }
    }
}
