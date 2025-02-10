using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerBehaviorAggressive : IPlayerBehavior
    {
        public void Enter()
        {
            Debug.Log("Enter AGGRESSIVE behavior");
        }

        public void Exit()
        {
            Debug.Log("Exit AGGRESSIVE behavior");
        }

        public void Update()
        {
            Debug.Log("Update AGGRESSIVE behavior");
        }
    }
}
