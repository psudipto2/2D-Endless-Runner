using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace StateMachine
{
    public class GrassState : State
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
