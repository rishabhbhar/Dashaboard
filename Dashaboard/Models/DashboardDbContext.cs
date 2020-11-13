using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Dashaboard.Models
{
    public class DashboardDbContext : DbContext
    {
        public  DbSet<Dashboard> dashboards { get; set; }

    }
}