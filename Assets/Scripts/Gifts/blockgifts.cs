using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockgifts : MonoBehaviour
{
    public enum BlockGifts {  machineLarger=0, threeshoot=1, twoshoot = 2, oneShoot =3,verticallaser=4,horizantallazer=5,coinsbag =6,none = 7}

    private  static BlockGifts GetGifts;
    public static BlockGifts Get_RandomGift()
    {
        int rand = Random.Range(0 , 25);
        if (rand > 6) rand = 6;
        GetGifts =  (BlockGifts) rand;

        return GetGifts;
    }

}
   