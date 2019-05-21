using System;
using Entities.Auditing;
using Entities.Enumerations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("TBL_SUB_PACKAGE")]
    public class SubPackage : FullAuditedEntity
    {
        #region Initial
        public SubPackage()
        {

        }
        #endregion

        #region Primary key
        [Column("SUB_PACKAGE_NO")]
        [StringLength(128)]
        public string SubPackageNo { get; set; }
        #endregion

        #region Foreign Key References
        [Required]
        [Column("TRANS_CD")]
        public Guid TransId { get; set; }
        #endregion

        #region Properties
        [Required]
        [Column("PRODUCT_NA")]
        [StringLength(2048)]
        public string ProductName { get; set; }

        [Required]
        [Column("QUANTITY")]
        public int Quantity { get; set; }

        [Required]
        [StringLength(1024)]
        [Column("PRICE")]
        public string Price { get; set; }

        [Required]
        [StringLength(4096)]
        [Column("DELIVERY_ADD")]
        public string AddressDelivery { get; set; }

        [Column("DELIVERY_TM")]
        public DateTime? DeliveryTime { get; set; } = null;

        [Required]
        [StringLength(2048)]
        [Column("STATUS")]
        public string StatusStr
        {
            get { return Status.ToString(); }
            set { Status = (PackageStatusEnum)Enum.Parse(typeof(PackageStatusEnum), value, true); }
        }

        [NotMapped]
        public PackageStatusEnum Status { get; set; }
        #endregion

        #region Relationship
        [ForeignKey("TransId")]
        public Transport Transport { get; set; }
        #endregion
    }
}
