using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsGondermeProje3.Model
{
    public class SQLiteDbContex : DbContext
    {

        public SQLiteDbContex() : base(new SQLiteConnection()
        {
            ConnectionString = new SQLiteConnectionStringBuilder()
            {
                DataSource = @"C:\Users\Ayça\source\repos\SmsGondermeProje3\SmsGondermeProje3\bin\Debug\MyDB.db",
                DefaultTimeout = 5000,
                SyncMode = SynchronizationModes.Off,
                JournalMode = SQLiteJournalModeEnum.Memory,
                PageSize = 65536,
                CacheSize = 16777216,
                FailIfMissing = false,
                ReadOnly = false
            }.ConnectionString
        }, true)



        {
            Database.SetInitializer<SQLiteDbContex>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Sirketler_Tbl>().ToTable("SIRKETLER");
            modelbuilder.Entity<Ayarlar_Tbl>().ToTable("AYARLAR");
            modelbuilder.Entity<KullaniciGiris_Tbl>().ToTable("GIRIS");
            modelbuilder.Entity<Cari_Tbl>().ToTable("CARI");
            modelbuilder.Entity<MesajDurum_Tbl>().ToTable("MESAJ_DURUM");
            modelbuilder.Entity<HazirMesaj_Tbl>().ToTable("MESAJ");



        }
        public DbSet<Sirketler_Tbl> SIRKETLER { get; set; }
        public DbSet<Ayarlar_Tbl> AYARLAR { get; set; }
        public DbSet<KullaniciGiris_Tbl> GIRIS { get; set; }
        public DbSet<Cari_Tbl> CARI { get; set; }
        public DbSet<MesajDurum_Tbl> MESAJ_DURUM { get; set; }
        public DbSet<HazirMesaj_Tbl> MESAJ { get; set; }


    }
}
