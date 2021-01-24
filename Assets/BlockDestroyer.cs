using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroyer : MonoBehaviour
{
    public bool DangerBlockArrive;
    [SerializeField]
    DangerBackground dangerBackground;
    [SerializeField]
    float timeTodecide = 7f;


    void ActiveDangeronBlocks(RaycastHit2D[] raycastHit2D)
    {
        for (int i = 0 ; i < raycastHit2D.Length ; i++)
        {
            if (raycastHit2D[i])
                if (raycastHit2D[i].transform.GetComponent<Block>() != null)
                {
                    raycastHit2D[i].transform.GetComponent<Block>().BlockInDanger();
                }
        }
         
    }
    private void Update()
    {

        RaycastHit2D[] raycastHit2D = Physics2D.RaycastAll(transform.position , Vector2.left,18f);
        for (int i = 0 ; i < raycastHit2D.Length ; i++)
        {
            if (raycastHit2D[i])
                if (raycastHit2D[i].transform.GetComponent<Block>() != null)
                {
                    DangerBlockArrive = true;
                    bool allblocksareunbreakable = true;
                    
                    if (!raycastHit2D[i].transform.gameObject.GetComponent<UnBreakerBlock>())
                    {
                        allblocksareunbreakable = false;
                    }

                    if (allblocksareunbreakable)
                    {
                        for (int x = 0 ; x < raycastHit2D.Length ; x++)
                        {
                            if (raycastHit2D[x])
                                if (raycastHit2D[x].transform.GetComponent<Block>() != null)
                                {
                                    Destroy(raycastHit2D[x].transform.GetComponent<Block>().transform.parent.gameObject);
                                    return;
                                }
                        }


                    }

                }
                else
                {
                    dangerBackground.ActiveDangerBackground(false);
                    return;
                }
        }




    
        if (DangerBlockArrive)
        {
            ActiveDangeronBlocks(raycastHit2D);
            dangerBackground.ActiveDangerBackground(true);
            timeTodecide -= Time.deltaTime;
            if (timeTodecide <= 0f)
            {
              
                destroyRow(raycastHit2D);
                timeTodecide = 7f;
                DangerBlockArrive = false;
                dangerBackground.ActiveDangerBackground(false);
              
            }
        }
       
    }
   
    
    void destroyRow(RaycastHit2D[] raycastHit2D)
    {
      
      
        for (int i = 0 ; i < raycastHit2D.Length ; i++)
        {
            if (raycastHit2D[i])
                if (raycastHit2D[i].transform.GetComponent<Block>() != null)
                {
                     
                        GameController.GameOver();
                        
                     
                }

        }
       
    }

}
