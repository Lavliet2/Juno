namespace PpdmModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    //using System.Data.Entity.Spatial;

    [Table("dbo.business_associate")]
    public partial class BusinessAssociate
    {
        public BusinessAssociate()
        {
            Contacts = new HashSet<BaContactInfo>();
        }

        [Key]
        [StringLength(40)]
        [Column("BUSINESS_ASSOCIATE_ID")]
        public string BusinessAssociateId { get; set; }

        [StringLength(1)]
        [Column("ACTIVE_IND")]
        public string ActiveInd { get; set; }

        [StringLength(12)]
        [Column("BA_ABBREVIATION")]
        public string BaAbbreviation { get; set; }

        [StringLength(40)]
        [Column("BA_CATEGORY")]
        public string BaCategory { get; set; }

        [StringLength(40)]
        [Column("BA_CODE")]
        public string BaCode { get; set; }

        [StringLength(255)]
        [Column("BA_LONG_NAME")]
        public string BaLongName { get; set; }

        [StringLength(30)]
        [Column("BA_SHORT_NAME")]
        public string BaShortName { get; set; }

        [StringLength(40)]
        [Column("BA_TYPE")]
        public string BaType { get; set; }

        [Column("CREDIT_CHECK_DATE", TypeName = "date")]
        public DateTime? CreditCheckDate { get; set; }

        [StringLength(1)]
        [Column("CREDIT_CHECK_IND")]
        public string CreditCheckInd { get; set; }

        [StringLength(40)]
        [Column("CREDIT_CHECK_SOURCE")]
        public string CreditCheckSource { get; set; }

        [StringLength(40)]
        [Column("CREDIT_RATING")]
        public string CreditRating { get; set; }

        [StringLength(40)]
        [Column("CREDIT_RATING_SOURCE")]
        public string CreditRatingSource { get; set; }

        [StringLength(40)]
        [Column("CURRENT_STATUS")]
        public string CurrentStatus { get; set; }

        [Column("EFFECTIVE_DATE", TypeName = "date")]
        public DateTime? EffectiveDate { get; set; }

        [Column("EXPIRY_DATE", TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }

        [StringLength(255)]
        [Column("FIRST_NAME")]
        public string FirstName { get; set; }

        [StringLength(255)]
        [Column("LAST_NAME")]
        public string LastName { get; set; }

        [StringLength(30)]
        [Column("MIDDLE_INITIAL")]
        public string MiddleInitial { get; set; }

        [Column("PPDM_GUID")]
        public Guid PpdmGuid { get; set; }

        [StringLength(2000)]
        [Column("REMARK")]
        public string Remark { get; set; }

        [StringLength(240)]
        [Column("SERVICE_PERIOD")]
        public string ServicePeriod { get; set; }

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

        public virtual ICollection<BaContactInfo> Contacts { get; set; }

        public string Email => Contacts.FirstOrDefault(c => c.ActiveInd == "Y" && c.ContactLocType == "EMAIL")?.LocationName;
    }
}
