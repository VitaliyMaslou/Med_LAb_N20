//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Med_LAb_N20
{
    using System;
    using System.Collections.Generic;
    
    public partial class Serv_order
    {
        public int Serv_order_id { get; set; }
        public Nullable<int> Servicesout_id { get; set; }
        public Nullable<int> Orders_id { get; set; }
    
        public virtual Orders Orders { get; set; }
        public virtual Servicesout Servicesout { get; set; }
    }
}