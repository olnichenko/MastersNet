namespace Dal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpecialityesToAd")]
    public partial class SpecialityesToAd
    {
        public long Id { get; set; }

        public short SpecialityId { get; set; }

        public long AdId { get; set; }

        public virtual Speciality Speciality { get; set; }

        public virtual Аdvertisement Аdvertisement { get; set; }
    }
}
