using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : Interact
{
    PlayerHandler player;
    CharacterStats myStats;
    // Start is called before the first frame update
    void Start()
    {
        player = PlayerHandler.instance;
    }

    // Update is called once per frame
    public override void Use()
    {
        base.Use()
        CharacterCombat playerCombat =  player.player.GetComponent<CharcterCombat>();
        if (playerCombat != null)
        {
            playerCombat.Attack(myStats);
        }
    }
}
