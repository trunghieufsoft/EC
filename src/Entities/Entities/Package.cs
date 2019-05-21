using System;
using Entities.Auditing;
using Entities.Enumerations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.Entities
{
    [Table("TBL_PACKAGE")]
    public class Package : FullAuditedEntity
    {
        #region Initial
        public Package()
        {
            Transports = new HashSet<Transport>();
        }
        #endregion

        #region Primary key
        [Column("PACKAGE_NO")]
        [StringLength(128)]
        public string PackageNo { get; set; }
        #endregion

        #region Foreign Key References

        #endregion

        #region Properties
        [Required]
        [StringLength(2048)]
        [Column("SENDER_ADD")]
        public string SenderAddress { get; set; }

        [Column("SENDER_TM")]
        public DateTime? SenderTime { get; set; } = null;
        
        [Required]
        [StringLength(2048)]
        [Column("STATUS")]
        public string StatusStr
        {
            get { return Status.ToString(); }
            set { Status = (TransStatusEnum)Enum.Parse(typeof(TransStatusEnum), value, true); }
        }

        [NotMapped]
        public TransStatusEnum Status { get; set; }
        #endregion

        #region Relationship
        public ICollection<Transport> Transports { get; set; }
        #endregion
    }
}
