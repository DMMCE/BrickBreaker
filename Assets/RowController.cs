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
        for (int i = 0 ; i < 5 ; i++)
        {
            CreatrowBlock();
        }
     
    }
    [SerializeField]
    float timetoRespawnRow=10f;
    bool respawn;
    private void Update()
    {
        if (!respawn)
        {
            timetoRespawnRow -= Time.deltaTime;
            if(timetoRespawnRow <= 0f)
            {
                CreatrowBlock();
                timetoRespawnRow = 10f;
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