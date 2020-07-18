using System.Collections.Generic;

namespace DatingApp.API.WorkFlowModels
{
    public class StateType
    {
        public int StateTypeId { get; set; }

        public string name { get; set; }

        public virtual ICollection<State> States { get; set; }
    }
}