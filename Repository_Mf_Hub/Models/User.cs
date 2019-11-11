namespace Repository_Mf_Hub
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string PasswordHash { get; set; }

        public string SecuritySalt { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public int ProfileId { get; set; }
    }
}
