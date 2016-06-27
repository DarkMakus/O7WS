using System.Data.Entity;
using Angkor.O7Common.Data.Entity;

namespace Angkor.O7Common.Data.Context
{
    public class SecurityContext : DbContext
    {
        public SecurityContext ( ) : base ("name=SecurityContext")
        {
        }

        public SecurityContext (string connecion) : base (connecion)
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.CTUCCODCIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCCODSUC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCCODUSR)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCCODSEC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCCODIMP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCCODCJA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCCODBCO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCNOMUSR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCNOMUOPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCFLGUOPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCCODPLA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCCODCOM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCPWDCLN)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCPWDSRV)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCCORREO)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCCODTRA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCCODUSRP)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCFLGEST)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCFLGSS)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCACTIVO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCCMBPSW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCFLAPSW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUIDIOMA)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CTUCFLGBLO)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.AUDUSRREG)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.AUDEQUREG)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.AUDUSRUPD)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.AUDEQUUPD)
                .IsUnicode(false);
        }

    }
}