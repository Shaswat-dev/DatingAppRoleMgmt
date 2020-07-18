using System;
using System.Collections.Generic;
using DatingApp.API.Models;

namespace DatingApp.API.WorkFlowModels

{
    public class Request
    {
        public int RequestId { get; set; }

        public string Tile { get; set; }

        public DateTime DateRequested { get; set; }

        
        public int UserId { get; set; }
        public virtual User User { get; set; }

       
        public string Username { get; set; }

         public int CurrentStateId { get; set; }
        public virtual State CurrentState { get; set; }
        
        public int ProcessId { get; set; }
        public virtual Process Process { get; set; }

        public virtual ICollection<RequestAction> RequestActions { get; set; }

        
    }
}