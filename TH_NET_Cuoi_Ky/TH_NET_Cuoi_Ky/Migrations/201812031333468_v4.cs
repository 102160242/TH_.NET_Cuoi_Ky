namespace TH_NET_Cuoi_Ky.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NguoiQL", "NgaySinh", c => c.DateTime(nullable: false));
            AddColumn("dbo.NguoiQL", "GioiTinh", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NguoiQL", "GioiTinh");
            DropColumn("dbo.NguoiQL", "NgaySinh");
        }
    }
}
