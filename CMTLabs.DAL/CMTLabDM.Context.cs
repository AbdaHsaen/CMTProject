﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMTLabs.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CMTLab_Entities : DbContext
    {
        public CMTLab_Entities()
            : base("name=CMTLab_Entities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<ClientContactsInfo> ClientContactsInfoes { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<DailyFieldReport> DailyFieldReports { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Login_Logout_Logs> Login_Logout_Logs { get; set; }
        public virtual DbSet<LookupCategory> LookupCategories { get; set; }
        public virtual DbSet<Lookup> Lookups { get; set; }
        public virtual DbSet<NuclearGauge> NuclearGauges { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<SoilMaterial> SoilMaterials { get; set; }
        public virtual DbSet<TimeRecord> TimeRecords { get; set; }
        public virtual DbSet<UsersRole> UsersRoles { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }
    }
}
