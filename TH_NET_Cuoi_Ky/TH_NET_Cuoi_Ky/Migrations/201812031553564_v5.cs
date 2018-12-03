namespace TH_NET_Cuoi_Ky.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NhapXuat", "NamSD", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NhapXuat", "NamSD", c => c.Int(nullable: false));
        }
    }
}
