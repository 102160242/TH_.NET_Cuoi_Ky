namespace TH_NET_Cuoi_Ky.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NguoiQL", "SoDT", c => c.String(nullable: false, maxLength: 11));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NguoiQL", "SoDT");
        }
    }
}
