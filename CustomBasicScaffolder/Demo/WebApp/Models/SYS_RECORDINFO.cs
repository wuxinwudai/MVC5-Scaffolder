namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYS_RECORDINFO")]
    public partial class SYS_RECORDINFO
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string BOOKATTRIBUTE { get; set; }

        [StringLength(50)]
        public string BUSIUNIT { get; set; }

        [StringLength(50)]
        public string RECEIVEUNIT { get; set; }

        [StringLength(50)]
        public string TRADE { get; set; }

        [StringLength(50)]
        public string EXEMPTING { get; set; }

        public decimal? ISMODEL { get; set; }

        public decimal? ENABLED { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public decimal? CREATEMAN { get; set; }

        public decimal? STOPMAN { get; set; }

        [StringLength(50)]
        public string RECEIVEUNITNAME { get; set; }
    }
}