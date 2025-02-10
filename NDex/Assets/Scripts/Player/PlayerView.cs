using Assets.Scripts.Player.FSM;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerView : MonoBehaviour
    {
        private FsmStateIdle _idle; // Теперь это поле
        public Animator animator;

        private const string IS_WALK = "isWalk";

        // Метод инициализации FsmStateIdle через класс FSM, к которому он принадлежит
        public void Init(Fsm fsm)
        {
            _idle = fsm.GetState<FsmStateIdle>(); // Получаем экземпляр FsmStateIdle из Fsm
            if (_idle == null)
            {
                Debug.LogError("Ошибка инициализации FsmStateIdle");
            }
            SubscribeToEvents();
        }

        private void OnEnable()
        {
            SubscribeToEvents();
        }

        private void OnDisable() // Исправлено имя метода OnDisable
        {
            UnsubscribeFromEvents();
        }

        private void StartIdle()
        {
            animator.SetBool(IS_WALK, false);
        }

        private void StartWalk()
        {
            animator.SetBool(IS_WALK, true);
        }

        private void SubscribeToEvents()
        {
            if (_idle != null)
            {
                _idle.OnIdle += StartIdle;
                _idle.OnWalk += StartWalk;
            }
        }

        private void UnsubscribeFromEvents()
        {
            if (_idle != null)
            {
                _idle.OnIdle -= StartIdle;
                _idle.OnWalk -= StartWalk;
            }
        }
    }
}
