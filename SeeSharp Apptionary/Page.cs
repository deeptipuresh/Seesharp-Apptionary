namespace SeeSharp_Apptionary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Page")]
    public partial class Page
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PageId { get; set; }

        [StringLength(2147483647)]
        public string Title { get; set; }

        [StringLength(2147483647)]
        public string Content { get; set; }
    }
}
