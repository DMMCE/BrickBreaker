using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{


    public blockgifts.BlockGifts GetBlockgifts;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MachineCollider"))
        {
            Active_Gift(collision);
            destroygift();
        }
     
    }
    public void destroygift()
    {
        Destroy(gameObject);
    }
    public virtual void Active_Gift(Collider2D collision)
    {
        Debug.Log("Gift to activate is " + GetBlockgifts);

    }

}
