//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FootballArea.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserve
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int AreaID { get; set; }
        public int RoomID { get; set; }
        public System.DateTime ReserveDateFrom { get; set; }
        public System.DateTime ReserveDateTo { get; set; }
        public string Price { get; set; }
    
        public virtual Areas Areas { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Rooms Rooms { get; set; }
    }
}
