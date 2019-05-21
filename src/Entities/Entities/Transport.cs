using System;
using Entities.Auditing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Enumerations;

namespace Entities.Entities
{
    [Table("TBL_TRANSPORT")]
    public class Transport : FullAuditedEntity
    {
        #region Initial
        public Transport()
        {
            SubPackages = new HashSet<SubPackage>();
        }
        #endregion

        #region Primary key

        #endregion

        #region Foreign Key References
        [Required]
        [Column("DRIVER_CD")]
        public Guid DriverId { get; set; }

        [Required]
        [Column("PACKAGE_NO")]
        public Guid PackageNo { get; set; }
        #endregion

        #region Properties
        [Required]
        [StringLength(2048)]
        [Column("TRANS_TYP")]
        public string TranTypeStr
        {
            get { return TranType.ToString(); }
            set { TranType = (TransTypeEnum)Enum.Parse(typeof(TransTypeEnum), value, true); }
        }

        [NotMapped]
        public TransTypeEnum TranType { get; set; }

        [Required]
        [StringLength(2048)]
        [Column("RECIPIENT_ADD")]
        public string RecipientAddress { get; set; }
        
        [StringLength(2048)]
        [Column("CONTENT")]
        public string Content { get; set; }

        [Column("PICKUP_TM")]
        public DateTime? PickUpTime { get; set; } = null;
        #endregion

        #region Relationship
        [ForeignKey("DriverId")]
        public User User { get; set; }

        [ForeignKey("PackageNo")]
        public Package Package { get; set; }

        public ICollection<SubPackage> SubPackages { get; set; }
        #endregion
    }
}
