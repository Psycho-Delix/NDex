namespace Assets.Scripts.Player.FSM
{
    public abstract class FsmState
    {
        protected readonly Fsm fsm;

        public FsmState(Fsm fsm)
        {
            this.fsm = fsm;
        }

        public virtual void Enter() {}
        public virtual void Exit() {}
        public virtual void Update() {}
    }
}

