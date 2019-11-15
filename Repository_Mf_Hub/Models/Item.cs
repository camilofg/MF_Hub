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
        //Foreign Key
        public int UserId { get; set; }
        //Navigation Property
        public User User { get; set; }
        //Foreign Key
        public int StatusId { get; set; }
        //Navigation property
        public Status Status { get; set; }
        //Foreign Key
        public int PriorityId { get; set; }
        //Navigation property
        public Priority Priority { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Dateline { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreationDate { get; set; }
        [DefaultValue(false)]
        public bool SetAlarm { get; set; }
    }
}
