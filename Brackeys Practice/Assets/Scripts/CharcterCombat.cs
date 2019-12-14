using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterStats))]
public class CharcterCombat : MonoBehaviour
{
    public float attackSpeed = 1f;
    private float attackCooldown = 0f;

    CharacterStats myStats;
    public void Attack (CharacterStats targetStats)
    {
        targetStats.TakeDamage(myStats.damage.GetValue());
    }
    // Start is called before the first frame update
    void Start()
    {
        myStats = GetComponent<CharacterStats>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
