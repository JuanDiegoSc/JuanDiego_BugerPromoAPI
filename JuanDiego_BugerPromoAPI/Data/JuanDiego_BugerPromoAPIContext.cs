using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JuanDiego_BugerPromoAPI.Data.Models;

namespace JuanDiego_BugerPromoAPI.Data
{
    public class JuanDiego_BugerPromoAPIContext : DbContext
    {
        public JuanDiego_BugerPromoAPIContext (DbContextOptions<JuanDiego_BugerPromoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<JuanDiego_BugerPromoAPI.Data.Models.Burger> Burger { get; set; } = default!;
        public DbSet<JuanDiego_BugerPromoAPI.Data.Models.Promo> Promo { get; set; } = default!;
    }
}
