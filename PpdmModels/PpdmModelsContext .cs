namespace PpdmModels
{
    using Microsoft.EntityFrameworkCore;
    using PpdmModels.Models;
    public class PpdmModelsContext : DbContext
    {
        public PpdmModelsContext(DbContextOptions<PpdmModelsContext> options)
            : base(options) { }

        public DbSet<BusinessAssociate> BaContactInfo { get; set; }
        public DbSet<BusinessAssociate> BusinessAssociates { get; set; }
        public DbSet<BusinessAssociateXRef> BusinessAssociateXRefs { get; set; }
        public DbSet<BaPermission> BaPermissions { get; set; }
    }
}
