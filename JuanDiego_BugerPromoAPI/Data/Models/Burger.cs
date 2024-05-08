using System;
using System.Collections.Generic;

namespace JuanDiego_BugerPromoAPI.Data.Models;

public partial class Burger
{
    public int BurgerId { get; set; }

    public string Name { get; set; } = null!;

    public bool WithCheese { get; set; }

    public decimal Precio { get; set; }

    public virtual ICollection<Promo> Promos { get; set; } = new List<Promo>();
}
