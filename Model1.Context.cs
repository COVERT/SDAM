﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDAM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PMEntities1 : DbContext
    {
        public PMEntities1()
            : base("name=PMEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BALL> BALL { get; set; }
        public virtual DbSet<DISS> DISS { get; set; }
        public virtual DbSet<GRUP> GRUP { get; set; }
        public virtual DbSet<SUDENT> SUDENT { get; set; }
    }
}
