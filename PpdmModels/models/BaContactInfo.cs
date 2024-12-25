namespace PpdmModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("ba_contact_info")]
    public partial class BaContactInfo
    {
        [Key]
        [Column("BUSINESS_ASSOCIATE_ID", Order = 0)]
        [StringLength(40)]
        public string BusinessAssociateId { get; set; }

        [Key]
        [Column("LOCATION_ID", Order = 1)]
        [StringLength(40)]
        public string LocationId { get; set; }

        [StringLength(1)]
        [Column("ACTIVE_IND")]
        public string ActiveInd { get; set; }

        [Column("ADDRESS_OBS_NO", TypeName = "numeric")]
        public decimal? AddressObsNo { get; set; }

        [StringLength(40)]
        [Column("ADDRESS_SOURCE")]
        public string AddressSource { get; set; }

        [StringLength(40)]
        [Column("BA_ORGANIZATION_ID")]
        public string BaOrganizationId { get; set; }

        [Column("BA_ORGANIZATION_SEQ_NO", TypeName = "numeric")]
        public decimal? BaOrganizationSeqNo { get; set; }

        [StringLength(40)]
        [Column("CONTACT_LOC_TYPE")]
        public string ContactLocType { get; set; }

        [StringLength(255)]
        [Column("LOCATION_NAME")]
        public string LocationName { get; set; }

        [Column("PPDM_GUID")]
        public Guid PpdmGuid { get; set; }

        [StringLength(1)]
        [Column("PREFERRED_IND")]
        public string PreferredInd { get; set; }

        [StringLength(2000)]
        [Column("REMARK")]
        public string Remark { get; set; }
    }
}
