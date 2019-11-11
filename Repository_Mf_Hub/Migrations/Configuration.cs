namespace Repository_Mf_Hub.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Repository_Mf_Hub.Mf_Hub_model>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Repository_Mf_Hub.Mf_Hub_model context)
        {
            context.Profiles.Add(new Profile {Description = "Admin"});
            context.Profiles.Add(new Profile { Description = "User" });

            context.Priorities.Add(new Priority { Description = "Urgent", MaxTime = 8});
            context.Priorities.Add(new Priority { Description = "Important", MaxTime = 48 });
            context.Priorities.Add(new Priority { Description = "Unimportant", MaxTime = 120 });

            context.Statuses.Add(new Status { Description = "Done" });
            context.Statuses.Add(new Status { Description = "In process" });
            context.Statuses.Add(new Status { Description = "To Do" });
        }
    }
}
