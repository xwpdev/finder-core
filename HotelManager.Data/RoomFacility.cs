//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoomFacility
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int FacilityId { get; set; }
    
        public virtual Facility Facility { get; set; }
        public virtual Room Room { get; set; }
    }
}
