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
    
    public partial class Pat_Serv
    {
        public int Pat_Serv_id { get; set; }
        public Nullable<int> Lab_Serveces_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string INN { get; set; }
        public string R_S { get; set; }
        public string BIK { get; set; }
    
        public virtual Lab_Serveces Lab_Serveces { get; set; }
    }
}