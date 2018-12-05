namespace TH_NET_Cuoi_Ky.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoaiTS",
                c => new
                    {
                        MaLoaiTS = c.Int(nullable: false, identity: true),
                        TenLoaiTS = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaLoaiTS);
            
            CreateTable(
                "dbo.TaiSan",
                c => new
                    {
                        MaTS = c.Int(nullable: false, identity: true),
                        TenTS = c.String(nullable: false),
                        TSKT = c.String(nullable: false, maxLength: 50),
                        DVTinh = c.String(nullable: false, maxLength: 50),
                        NamSX = c.Int(nullable: false),
                        MaNuocSX = c.Int(nullable: false),
                        MaLoaiTS = c.Int(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.MaTS)
                .ForeignKey("dbo.LoaiTS", t => t.MaLoaiTS, cascadeDelete: true)
                .ForeignKey("dbo.NuocSX", t => t.MaNuocSX, cascadeDelete: true)
                .Index(t => t.MaNuocSX)
                .Index(t => t.MaLoaiTS);
            
            CreateTable(
                "dbo.NhapXuat",
                c => new
                    {
                        SoPhieu = c.Int(nullable: false, identity: true),
                        MaTS = c.Int(nullable: false),
                        MaNhaCC = c.Int(nullable: false),
                        MaPhong = c.Int(nullable: false),
                        NgayNhap = c.DateTime(),
                        SLNhap = c.Int(),
                        NgayXuat = c.DateTime(),
                        SLXuat = c.Int(),
                        NguyenGia = c.Double(nullable: false),
                        NamSD = c.Int(),
                        TinhTrang = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.SoPhieu)
                .ForeignKey("dbo.NhaCC", t => t.MaNhaCC, cascadeDelete: true)
                .ForeignKey("dbo.Phong", t => t.MaPhong, cascadeDelete: true)
                .ForeignKey("dbo.TaiSan", t => t.MaTS, cascadeDelete: true)
                .Index(t => t.MaTS)
                .Index(t => t.MaNhaCC)
                .Index(t => t.MaPhong);
            
            CreateTable(
                "dbo.NhaCC",
                c => new
                    {
                        MaNhaCC = c.Int(nullable: false, identity: true),
                        TenNhaCC = c.String(nullable: false, maxLength: 50),
                        DiaChi = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaNhaCC);
            
            CreateTable(
                "dbo.Phong",
                c => new
                    {
                        MaPhong = c.Int(nullable: false, identity: true),
                        TenPhong = c.String(nullable: false, maxLength: 50),
                        MaNguoiQL = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhong)
                .ForeignKey("dbo.NguoiQL", t => t.MaNguoiQL, cascadeDelete: true)
                .Index(t => t.MaNguoiQL);
            
            CreateTable(
                "dbo.NguoiQL",
                c => new
                    {
                        MaNguoiQL = c.Int(nullable: false, identity: true),
                        TenNguoiQL = c.String(nullable: false, maxLength: 50),
                        SoDT = c.String(nullable: false, maxLength: 11),
                        NgaySinh = c.DateTime(nullable: false),
                        GioiTinh = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaNguoiQL);
            
            CreateTable(
                "dbo.NuocSX",
                c => new
                    {
                        MaNuocSX = c.Int(nullable: false, identity: true),
                        TenNuocSX = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaNuocSX);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaiSan", "MaNuocSX", "dbo.NuocSX");
            DropForeignKey("dbo.NhapXuat", "MaTS", "dbo.TaiSan");
            DropForeignKey("dbo.NhapXuat", "MaPhong", "dbo.Phong");
            DropForeignKey("dbo.Phong", "MaNguoiQL", "dbo.NguoiQL");
            DropForeignKey("dbo.NhapXuat", "MaNhaCC", "dbo.NhaCC");
            DropForeignKey("dbo.TaiSan", "MaLoaiTS", "dbo.LoaiTS");
            DropIndex("dbo.Phong", new[] { "MaNguoiQL" });
            DropIndex("dbo.NhapXuat", new[] { "MaPhong" });
            DropIndex("dbo.NhapXuat", new[] { "MaNhaCC" });
            DropIndex("dbo.NhapXuat", new[] { "MaTS" });
            DropIndex("dbo.TaiSan", new[] { "MaLoaiTS" });
            DropIndex("dbo.TaiSan", new[] { "MaNuocSX" });
            DropTable("dbo.NuocSX");
            DropTable("dbo.NguoiQL");
            DropTable("dbo.Phong");
            DropTable("dbo.NhaCC");
            DropTable("dbo.NhapXuat");
            DropTable("dbo.TaiSan");
            DropTable("dbo.LoaiTS");
        }
    }
}
