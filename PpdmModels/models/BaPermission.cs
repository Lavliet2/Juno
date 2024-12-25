namespace PpdmModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("juno.BA_PERMISSION")]
    public partial class BaPermission
    {
        [Key]		
        [Column("BUSINESS_ASSOCIATE_ID", Order = 0)]
        public string BaId { get; set; }
		
		[Key]
        [Column("PERMISSION_ID", Order = 1)]
        public Guid PermissionId { get; set; }
    }
}
