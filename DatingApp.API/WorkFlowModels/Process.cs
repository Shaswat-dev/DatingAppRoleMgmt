using System.Collections.Generic;

namespace DatingApp.API.WorkFlowModels
{
    public class Process
    {
        public int ProcessId { get; set; }

        public string ProcessName { get; set; }

        public virtual ICollection<Request> Requests { get; set; }

        public virtual ICollection<State> States { get; set; }

        public virtual ICollection<Transition> Transitions { get; set; }

        public virtual ICollection<Action> Actions { get; set; }
    }
}