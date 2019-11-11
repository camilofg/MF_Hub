using System.ComponentModel;

namespace Repository_Mf_Hub
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item
    {
        public int ItemId { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        public int StatusId { get; set; }

        public int PriorityId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Dateline { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreationDate { get; set; }
        [DefaultValue(false)]
        public bool SetAlarm { get; set; }
    }
}
