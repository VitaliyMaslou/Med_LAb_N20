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
    
    public partial class Buhgalter_company
    {
        public int Buhgalter_company_id { get; set; }
        public Nullable<int> Buhgalter_id { get; set; }
        public Nullable<int> Orders_id { get; set; }
        public Nullable<int> SaveCompanyData_id { get; set; }
    
        public virtual Buhgalter Buhgalter { get; set; }
        public virtual Orders Orders { get; set; }
        public virtual SaveCompanyData SaveCompanyData { get; set; }
    }
}
