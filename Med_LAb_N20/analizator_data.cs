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
    
    public partial class analizator_data
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public analizator_data()
        {
            this.Servicesout = new HashSet<Servicesout>();
        }
    
        public int analizator_data_id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.DateTime> datework { get; set; }
        public Nullable<System.TimeSpan> timework { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servicesout> Servicesout { get; set; }
    }
}
