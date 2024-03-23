using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : Warrior
{
    public override void Attack()
    {
        
        base.Attack();
        Debug.Log("2nd Job: Swordsman");
    }
}
