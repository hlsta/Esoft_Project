//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Esoft_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class SupplySet
    {
        public int Id { get; set; }
        public int IdAgent { get; set; }
        public int IdClient { get; set; }
        public int IdRealEstate { get; set; }
        public long Price { get; set; }
    
        public virtual AgentsSet AgentsSet { get; set; }
        public virtual ClientSet ClientSet { get; set; }
        public virtual RealEstateSet RealEstateSet { get; set; }
    }
}
