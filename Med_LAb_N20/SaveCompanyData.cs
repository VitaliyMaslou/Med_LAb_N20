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
    
    public partial class SaveCompanyData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SaveCompanyData()
        {
            this.Buhgalter_company = new HashSet<Buhgalter_company>();
            this.Buhgalter_order = new HashSet<Buhgalter_order>();
        }
    
        public int SaveCompanyData_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string INN { get; set; }
        public string R_S { get; set; }
        public string BIK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buhgalter_company> Buhgalter_company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buhgalter_order> Buhgalter_order { get; set; }
    }
}
