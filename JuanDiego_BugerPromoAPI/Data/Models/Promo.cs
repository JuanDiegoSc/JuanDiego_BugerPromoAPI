using System;
using System.Collections.Generic;

namespace JuanDiego_BugerPromoAPI.Data.Models;

public partial class Promo
{
    public int PromoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public DateTime FechaPromo { get; set; }

    public int BurgerId { get; set; }

    public virtual Burger Burger { get; set; } = null!;
}
