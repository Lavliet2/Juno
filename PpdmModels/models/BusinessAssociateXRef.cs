namespace PpdmModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("dbo.ba_xref")]
    public partial class BusinessAssociateXRef
    {
        [Key]
        [Column("BUSINESS_ASSOCIATE_ID", Order = 0)]
        [StringLength(40)]
        public string BusinessAssociateId { get; set; }

        [Key]
        [Column("NEW_BA_ID", Order = 1)]
        [StringLength(40)]
        public string NewBaId { get; set; }

        [Key]
        [Column("BA_XREF_SEQ_NO", Order = 2, TypeName = "numeric")]
        public decimal BaXrefSeqNo { get; set; }

        [StringLength(1)]
        [Column("ACTIVE_IND")]
        public string ActiveInd { get; set; }

        [StringLength(40)]
        [Column("BA_XREF_TYPE")]
        public string BaXrefType { get; set; }

        [Column("EFFECTIVE_DATE", TypeName = "date")]
        public DateTime? EffectiveDate { get; set; }

        [Column("EXPIRY_DATE", TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }

        [Column("PPDM_GUID")]
        public Guid PpdmGuid { get; set; }

        [StringLength(2000)]
        [Column("REMARK")]
        public string Remark { get; set; }

        [StringLength(40)]
        [Column("SOURCE")]
        public string Source { get; set; }

        [StringLength(30)]
        [Column("ROW_CHANGED_BY")]
        public string RowChangedBy { get; set; }

        [Column("ROW_CHANGED_DATE", TypeName = "date")]
        public DateTime? RowChangedDate { get; set; }

        [StringLength(30)]
        [Column("ROW_CREATED_BY")]
        public string RowCreatedBy { get; set; }

        [Column("ROW_CREATED_DATE", TypeName = "date")]
        public DateTime? RowCreatedDate { get; set; }

        [Column("ROW_EFFECTIVE_DATE", TypeName = "date")]
        public DateTime? RowEffectiveDate { get; set; }

        [Column("ROW_EXPIRY_DATE", TypeName = "date")]
        public DateTime? RowExpiryDate { get; set; }

        [StringLength(40)]
        [Column("ROW_QUALITY")]
        public string RowQuality { get; set; }
    }
}
