using UnityEngine;

namespace Assets.Scripts.Player.FSM
{
    public class FsmStateWalk : FsmStateMovement
    {
        public FsmStateWalk(Fsm fsm, Transform transform, float speed) : base(fsm, transform, speed) {}

        public override void Update()
        {
            Debug.Log($"Walk state [UPDATE] wint speed: {Speed}");

            var inputDirection = ReadInput();

            if(inputDirection.sqrMagnitude == 0f)
            {
                fsm.SetState<FsmStateIdle>();

                //событие на анимацию покоя
            }

            if(Input.GetKeyDown(KeyCode.LeftShift))
            {
                fsm.SetState<FsmStateRun>();    

                //событие на анимацию бега
            }

            Move(inputDirection);
        }
    }
}
