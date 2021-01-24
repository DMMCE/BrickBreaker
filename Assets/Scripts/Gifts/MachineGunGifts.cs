 
using UnityEngine;

public class MachineGunGifts : MonoBehaviour
{
    [SerializeField]
    MachineGun GetGunGifts;

    
    public void numberOf_Guns(int value)
    {
        GetGunGifts.NumberofGuns  = value;
    }
    public void Add_Bullets(int value)
    {
        GetGunGifts.NumberofBullet += value;
    }
}
