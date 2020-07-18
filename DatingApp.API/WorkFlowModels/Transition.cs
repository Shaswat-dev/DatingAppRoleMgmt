using System.Collections.Generic;

namespace DatingApp.API.WorkFlowModels
{
    public class Transition
    {
        public int TransitionId { get; set; }

        public virtual Process Process { get; set; }
        public int ProcessId { get; set; }

        public virtual State CurrentState { get; set; }
        public int CurrentStateId { get; set; }

        public virtual State NextState { get; set; }
        public int NextStateId { get; set; }

        public virtual ICollection<TransitionAction> TransititionActions { get; set; }

        public virtual ICollection<RequestAction> RequestActions { get; set; }
    }

}