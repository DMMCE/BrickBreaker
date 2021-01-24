using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : Gift
{
    [SerializeField]
    int numberOfbullet;

    [SerializeField]
    int numberOfGuns;
    MachineGunGifts GetMachineGun;
    public void Awake()
    {
        GetMachineGun = GameObject.FindGameObjectWithTag("Machine").GetComponent<MachineGunGifts>();
    }
    public override void Active_Gift(Collider2D collision)
    {
        GetMachineGun.Add_Bullets(numberOfbullet);
        GetMachineGun.numberOf_Guns(numberOfGuns);
        base.Active_Gift(collision);
        
    }
}
