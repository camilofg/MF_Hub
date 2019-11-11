namespace Repository_Mf_Hub
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Statuses")]
    public partial class Status
    {
        public int StatusId { get; set; }

        public string Description { get; set; }
    }
}
