﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Esoft_ProjectEntities : DbContext
    {
        public Esoft_ProjectEntities()
            : base("name=Esoft_ProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AgentsSet> AgentsSet { get; set; }
        public virtual DbSet<ClientSet> ClientSet { get; set; }
        public virtual DbSet<RealEstateSet> RealEstateSet { get; set; }
    }
}
