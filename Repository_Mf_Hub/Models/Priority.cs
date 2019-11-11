namespace Repository_Mf_Hub
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Priority
    {
        public int PriorityId { get; set; }

        public string Description { get; set; }

        public int MaxTime { get; set; }
    }
}
