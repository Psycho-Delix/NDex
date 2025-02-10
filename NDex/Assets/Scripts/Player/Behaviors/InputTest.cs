using Assets.Scripts.Player;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    public Player player;

    private void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.C))
        {
            player.SetBehaviorActive();
        }
        if(Input.GetKeyDown(KeyCode.I))
        {
            player.SetBehaviorIdle();
        }
    }
}
