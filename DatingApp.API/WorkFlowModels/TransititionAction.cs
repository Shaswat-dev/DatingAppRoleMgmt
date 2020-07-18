namespace DatingApp.API.WorkFlowModels
{
    public class TransitionAction
    {
        public virtual Transition Transition { get; set; }
        public virtual int TransitionId { get; set; }

        public virtual Action Action { get; set; }
        public virtual int ActionId { get; set; }
    }
}