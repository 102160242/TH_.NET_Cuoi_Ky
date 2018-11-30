namespace TH_NET_Cuoi_Ky.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using TH_NET_Cuoi_Ky.DTO;
    public class QLCSVC : DbContext
    {
        // Your context has been configured to use a 'QLCSVC' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TH_NET_Cuoi_Ky.QLCSVC' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLCSVC' 
        // connection string in the application configuration file.
        public QLCSVC()
            : base("name=QLCSVC")
        {
            Database.SetInitializer<QLCSVC>(new DB());
        }

        // ReloadData a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<LoaiTS> LoaiTSs { get; set; }
        public virtual DbSet<NguoiQL> NguoiQLs { get; set; }
        public virtual DbSet<NhaCC> NhaCCs { get; set; }
        public virtual DbSet<NhapXuat> NhapXuats { get; set; }
        public virtual DbSet<NuocSX> NuocSXs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<TaiSan> TaiSans { get; set; }
    }
    public class DB: CreateDatabaseIfNotExists<QLCSVC>
    {
        protected override void Seed(QLCSVC context)
        {
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}