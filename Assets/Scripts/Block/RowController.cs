using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowController : MonoBehaviour
{
    [SerializeField]
    BlockRowManager getPrefab;
    [SerializeField]
    Vector2 startPosition;
    [SerializeField]
    GiftsManager giftsManager;
    private void Awake()
    {
        for (int i = 0 ; i < 2 ; i++)
        {
            CreatrowBlock();
        }
        currentrespawntime = timetoRespawnRow;
    }
  
    [SerializeField]
    float timetoRespawnRow=20f;
    float currentrespawntime;
    bool respawn;
    private void Update()
    {
        if (!respawn)
        {
            currentrespawntime -= Time.deltaTime;
            if(currentrespawntime <= 0f)
            {
                CreatrowBlock();
                currentrespawntime = timetoRespawnRow;
            }
        }
 
    }

    BlockRowManager CreatrowBlock()
    {
        BlockRowManager blockmanager = 
            GameObject.Instantiate(getPrefab , startPosition , Quaternion.Euler(Vector3.zero) , transform);
        blockmanager.transform.localPosition = startPosition;
        translateRowholdertoButtom();
        respawn = false;
        return blockmanager;
    }
    void translateRowholdertoButtom()
    {
        startPosition = new Vector2(startPosition.x , startPosition.y + 1f);
        giftsManager.translateUnfroozengifts();
        transform.position = new Vector3(transform.position.x , transform.position.y - 1f , transform.position.z);
    }
}