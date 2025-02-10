using UnityEngine;

namespace Assets.Scripts.Player.FSM
{
    public class FsmStateRun : FsmStateMovement
    {
        public FsmStateRun(Fsm fsm, Transform transform, float speed) : base(fsm, transform, speed) {}

        public override void Update()
        {
            Debug.Log($"Run state [UPDATE] with speed: {Speed}");

            var inputDirection = ReadInput();

            if(inputDirection.sqrMagnitude == 0f)
            {
                fsm.SetState<FsmStateIdle>();

                //событие на анимациб покоя
            }

            if(Input.GetKeyUp(KeyCode.LeftShift))
            {
                fsm.SetState<FsmStateWalk>();   

                //событие на анимацию ходьбы
            }

            Move(inputDirection);
        }
    }
}
