//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.ChatDetails = new HashSet<ChatDetail>();
            this.ChatDetails1 = new HashSet<ChatDetail>();
            this.ChatMasters = new HashSet<ChatMaster>();
            this.ChatMasters1 = new HashSet<ChatMaster>();
        }
    
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string UserNickname { get; set; }
    
        public virtual ICollection<ChatDetail> ChatDetails { get; set; }
        public virtual ICollection<ChatDetail> ChatDetails1 { get; set; }
        public virtual ICollection<ChatMaster> ChatMasters { get; set; }
        public virtual ICollection<ChatMaster> ChatMasters1 { get; set; }
    }
}
