//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterPiece.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvitationCardForm
    {
        public int InvitationCardFormId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> CardDesignId { get; set; }
        public string GroomName { get; set; }
        public string BrideName { get; set; }
        public Nullable<System.DateTime> WeddingDate { get; set; }
        public string Venue { get; set; }
        public string AdditionalNotes { get; set; }
        public Nullable<System.TimeSpan> TimeFrom { get; set; }
        public Nullable<System.TimeSpan> TimeTo { get; set; }
    
        public virtual InvitationCard InvitationCard { get; set; }
        public virtual User User { get; set; }
    }
}
