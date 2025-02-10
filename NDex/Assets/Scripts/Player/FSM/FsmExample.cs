using UnityEngine;

namespace Assets.Scripts.Player.FSM
{
    public class FsmExample : MonoBehaviour
    {
        private Fsm _fsm;
        [SerializeField] private float _walkSpeed = 10f;
        [SerializeField] private float _runSpeed = 20f;

        public PlayerView playerView; 

        private void Start()
        {
            _fsm = new Fsm();
            _fsm.AddSate(new FsmStateIdle(_fsm));
            _fsm.AddSate(new FsmStateWalk(_fsm, transform, _walkSpeed));
            _fsm.AddSate(new FsmStateRun(_fsm, transform, _runSpeed));

            _fsm.SetState<FsmStateIdle>();

            playerView.Init(_fsm);
        }

        private void Update()
        {
            _fsm.Update();
        }
    }
}
