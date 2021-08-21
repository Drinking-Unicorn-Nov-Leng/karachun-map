using karachun_map.Data.Attributes;
using karachun_map.Data.Entity;
using karachun_map.General.Expansions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karachun_map.EF
{
    public partial class ServiceDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
