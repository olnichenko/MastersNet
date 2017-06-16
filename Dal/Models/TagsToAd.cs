namespace Dal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TagsToAd")]
    public partial class TagsToAd
    {
        public long Id { get; set; }

        public int TagId { get; set; }

        public long AdId { get; set; }

        public virtual Tag Tag { get; set; }

        public virtual Аdvertisement Аdvertisement { get; set; }
    }
}
