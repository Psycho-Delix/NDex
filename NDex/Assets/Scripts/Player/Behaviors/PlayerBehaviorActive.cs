using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerBehaviorActive : IPlayerBehavior
    {
        public void Enter()
        {
            Debug.Log("Enter ACTIVE behavior");
        }

        public void Exit()
        {
            Debug.Log("Exit ACTIVE behavior");
        }

        public void Update()
        {
            Debug.Log("Update ACTIVE behavior");
        }
    }
}
