﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KNSession207_02_2020
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KNSession2Entities : DbContext
    {
        public KNSession2Entities()
            : base("name=KNSession2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AssetGroup> AssetGroups { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<ChangedPart> ChangedParts { get; set; }
        public virtual DbSet<DepartmentLocation> DepartmentLocations { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<EmergencyMaintenance> EmergencyMaintenances { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<Priority> Priorities { get; set; }
    }
}
