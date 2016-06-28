using System.Data.Entity;
using Angkor.O7Common.Data.Entity;

namespace Angkor.O7Common.Data.Context
{
    public class SecurityContext : DbContext
    {
        public SecurityContext (string connection) : base (connection)
        {
        }

        public virtual DbSet<CTDMUSRCIA> CTDMUSRCIAs { get; set; }

        protected override void OnModelCreating (DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCCODCIA).IsFixedLength ( ).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCCODSUC).IsFixedLength ( ).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCCODUSR).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCCODSEC).IsFixedLength ( ).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCCODIMP).IsFixedLength ( ).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCCODCJA).IsFixedLength ( ).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCCODBCO).IsFixedLength ( ).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCNOMUSR).IsFixedLength ( ).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCNOMUOPE).IsFixedLength ( ).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCFLGUOPE).IsFixedLength ( ).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCCODPLA).IsFixedLength ( ).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCCODCOM).IsFixedLength ( ).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCPWDCLN).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCPWDSRV).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCCORREO).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCCODTRA).IsFixedLength ( ).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCCODUSRP).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCPWDCLN2).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCFLGEST).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCACTIVO).IsFixedLength ( ).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCCMBPSW).IsFixedLength ( ).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUCFLAPSW).IsFixedLength ( ).IsUnicode (false);

            modelBuilder.Entity<CTDMUSRCIA> ( ).Property (e => e.CTUIDIOMA).IsUnicode (false);
        }
    }
}