//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NCRSocialNetwork.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Club
    {
        public Club()
        {
            this.ClubComments = new HashSet<ClubComment>();
            this.Events = new HashSet<Event>();
            this.ClubSubscribtions = new HashSet<ClubSubscribtion>();
            this.Users = new HashSet<User>();
            this.ClubEvents = new HashSet<ClubEvent>();
        }
    
        public int ClubId { get; set; }
        public string ClubName { get; set; }
        public string ClubDescription { get; set; }
    
        public virtual ICollection<ClubComment> ClubComments { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<ClubSubscribtion> ClubSubscribtions { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<ClubEvent> ClubEvents { get; set; }
    }
}
