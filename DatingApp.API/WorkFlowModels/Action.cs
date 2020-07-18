using System.Collections.Generic;

namespace DatingApp.API.WorkFlowModels
{
    public class Action
    {
        public int ActionId { get; set; }

        public int ActionTypeId { get; set; }
        public virtual Process Process { get; set; }
        public int ProcessId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<TransitionAction> TransititionActions { get; set; }

        public virtual ICollection<ActionTarget> ActionTargets { get; set; }

        public virtual ICollection<RequestAction> RequestActions { get; set; }


    }
}