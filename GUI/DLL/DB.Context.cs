﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FinalProjectEntities : DbContext
    {
        public FinalProjectEntities()
            : base("name=FinalProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<activity> activities { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<uploadedProfile> uploadedProfiles { get; set; }
    
        public virtual ObjectResult<sampleProcedure_Result> sampleProcedure()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sampleProcedure_Result>("sampleProcedure");
        }
    }
}
