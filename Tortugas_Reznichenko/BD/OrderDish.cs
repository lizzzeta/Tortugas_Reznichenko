//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tortugas_Reznichenko.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDish
    {
        public int IdOrderDish { get; set; }
        public int IdOrder { get; set; }
        public int IdDish { get; set; }
        public int Qty { get; set; }
    
        public virtual Dish Dish { get; set; }
        public virtual Order Order { get; set; }
    }
}