using System.Collections.Generic;

namespace DatingApp.API.WorkFlowModels
{
    public class State
    {
        public int StateId { get; set; }

        public int StateTypeId { get; set; }
        public virtual StateType StateType { get; set; }
        

        public int ProcessId { get; set; }
        public virtual Process Process { get; set; }

        
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Request> Requests { get; set; }

        public virtual ICollection<Transition> Transitionnexts { get; set; }
        public virtual ICollection<Transition> Transitioncurrents { get; set; }
      

    }
}