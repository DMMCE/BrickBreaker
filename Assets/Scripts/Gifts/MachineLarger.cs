using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineLarger : Gift
{
   
    MachineSizeGift GetSizeGift;
    public void Awake()
    {
        GetSizeGift = GameObject.FindGameObjectWithTag("Machine").GetComponent<MachineSizeGift>();
    }
    public override void Active_Gift(Collider2D collision)
    {
        GetSizeGift.addmachineSize(true);
        base.Active_Gift(collision);

    }
   
}
