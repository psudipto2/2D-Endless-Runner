namespace StateMachine
{
    public class RockState : State
    {
        public override void OnStateEnter()
        {
            base.OnStateEnter();
            this.enabled = true;
            activeState = this;
        }
        public override void OnStateExit()
        {
            base.OnStateExit();
        }
        private void Update()
        {
            base.Update();
        }
    }
}
