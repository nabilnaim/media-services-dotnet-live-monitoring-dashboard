﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediaDashboard.Persistence.Storage
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AMSDashboardEntities1 : DbContext
    {
        public AMSDashboardEntities1()
            : base("name=AMSDashboardEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alert> Alerts { get; set; }
        public virtual DbSet<AlertType> AlertTypes { get; set; }
        public virtual DbSet<Channel> Channels { get; set; }
        public virtual DbSet<MediaServicesAccount> MediaServicesAccounts { get; set; }
        public virtual DbSet<Origin> Origins { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<ArchiveAlert> ArchiveAlerts { get; set; }
        public virtual DbSet<ChannelAlert> ChannelAlerts { get; set; }
        public virtual DbSet<GlobalAlert> GlobalAlerts { get; set; }
        public virtual DbSet<OriginAlert> OriginAlerts { get; set; }
    }
}
