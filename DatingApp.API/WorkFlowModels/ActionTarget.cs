namespace DatingApp.API.WorkFlowModels
{
    public class ActionTarget
    {
        public int ActionTargetId { get; set; }

        public virtual Action Action { get; set; }
        public int ActionId { get; set; }

        public int TargetUserId { get; set; }
    }
}