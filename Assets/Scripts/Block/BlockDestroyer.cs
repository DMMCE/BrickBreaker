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
    RaycastHit2D[] raycastHit2D;
    private void Update()
    {
       
            raycastHit2D = Physics2D.RaycastAll(transform.position , Vector2.left , 18f);
            for (int i = 0 ; i < raycastHit2D.Length ; i++)
            {
                if (raycastHit2D[i])
                    if (raycastHit2D[i].transform.GetComponent<Block>() != null)
                    { 
                        if (!raycastHit2D[i].transform.gameObject.GetComponent<UnBreakerBlock>()
                            && raycastHit2D[i].transform.GetComponent<Block>())
                        {
                            Debug.Log("normal blocks here");
                           
                            DangerBlockArrive = true;
                            break;
                        }
                       
                        

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
