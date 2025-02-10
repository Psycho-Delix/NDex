using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerBehaviorIdle : IPlayerBehavior
    {
        public void Enter()
        {
            Debug.Log("Enter IDLE behavior");
        }

        public void Exit()
        {
            Debug.Log("Exit IDLE behavior");
        }

        public void Update()
        {
            Debug.Log("Update IDLE behavior");
        }
    }
}
