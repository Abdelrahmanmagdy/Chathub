﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatMaster.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ChatHubEntities : DbContext
    {
        public ChatHubEntities()
            : base("name=ChatHubEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ChatDetail> ChatDetails { get; set; }
        public DbSet<ChatMaster> ChatMasters { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
