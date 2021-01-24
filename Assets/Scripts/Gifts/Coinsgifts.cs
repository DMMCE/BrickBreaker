using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinsgifts : Gift
{
    [SerializeField]
    int numberofCoins;
  
    public override void Active_Gift(Collider2D collision)
    {
        CoinsManager.AddCoins(Random.Range(1 , 4));
        base.Active_Gift(collision);

    }
}
