using System;
using UnityEngine;

namespace Assets.Scripts.Player.FSM
{
    public class FsmStateIdle : FsmState
    {
        public event Action OnIdle;
        public event Action OnWalk;
        public FsmStateIdle(Fsm fsm) : base(fsm) {}

        public override void Enter()
        {
            Debug.Log("Idle state [ENTER]");
        }

        public override void Exit() 
        {
            Debug.Log("Idle state [EXIT]");
        }

        public override void Update()
        {
            Debug.Log("Idle state [UPDATE]");

            if(Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f)
            {
                fsm.SetState<FsmStateWalk>();

                OnWalk?.Invoke();
            }
            else {
                OnIdle?.Invoke();
            }
        }
    }
}
