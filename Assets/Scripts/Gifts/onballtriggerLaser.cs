using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onballtriggerLaser : MonoBehaviour
{
   public List<Block> getallBlocks(bool vertical)
    {
        List<Block> newlist = new List<Block>();
        if (vertical)
        {
            RaycastHit2D[] raycastHit2D = Physics2D.RaycastAll(transform.position , Vector2.up);
            RaycastHit2D[] raycast2D = Physics2D.RaycastAll(transform.position , Vector2.down);
           
            for (int i = 0 ; i < raycastHit2D.Length ; i++)
            {
                if (raycastHit2D[i].collider)
                    if (raycastHit2D[i].transform.GetComponent<Block>() != null)
                newlist.Add(raycastHit2D[i].transform.GetComponent<Block>());

             

            }
            for (int i = 0 ; i < raycast2D.Length ; i++)
            {
                if(raycast2D[i].collider)
                if (raycast2D[i].transform.GetComponent<Block>() != null)
                    newlist.Add(raycast2D[i].transform.GetComponent<Block>());

               
            }
           
        }
        else
        {
            RaycastHit2D[] raycastHit2D = Physics2D.RaycastAll(transform.position , Vector2.right);
            RaycastHit2D[] raycast2D = Physics2D.RaycastAll(transform.position , Vector2.left);
 

            for (int i = 0 ; i < raycastHit2D.Length ; i++)
            {
                if (raycastHit2D[i].collider)
                    if (raycastHit2D[i].transform.GetComponent<Block>() != null)
                    newlist.Add(raycastHit2D[i].transform.GetComponent<Block>());

 

            }
            for (int i = 0 ; i < raycast2D.Length ; i++)
            {
                if (raycast2D[i].collider)
                    if (raycast2D[i].transform.GetComponent<Block>() != null)
                    newlist.Add(raycast2D[i].transform.GetComponent<Block>());

               
            }
        }
        return newlist;
    }
}
