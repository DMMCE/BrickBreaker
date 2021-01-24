using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRowManager : MonoBehaviour
{
    [SerializeField]
    int maximumNumberofBlockPerRow;
    [SerializeField]
    Vector2 startCreatingBlocks;

    [SerializeField]
    Block[] GetAllprefabs;

    [SerializeField]
    List<Block> GetBlock;

    int randomNumberofdestroyedBlocks;
    void Start()
    {
       
        for (int i = 0 ; i < maximumNumberofBlockPerRow ; i++)
        {
            creatBlock();
        }
        randomNumberofdestroyedBlocks = Random.Range(0 , 10);
        GetBlock = getAllBlocksChildren();

        for (int i = 0 ; i < GetBlock.Count ; i++)
        {
            float rand = Random.value ;
            if(rand >= 0.4f && randomNumberofdestroyedBlocks > 0)
            {
 
                Destroy(GetBlock[i].gameObject);
                GetBlock.RemoveAt(i);
                randomNumberofdestroyedBlocks--;
            }
            else
            {

            }
        }
    }
    void creatBlock()
    {
      Block newblock =
            GameObject.Instantiate(GetRandomBlock() , startCreatingBlocks 
            , Quaternion.Euler(Vector3.zero) , transform);
        newblock.transform.localPosition = startCreatingBlocks;
        newblock.name = startCreatingBlocks.x.ToString() ;
        startCreatingBlocks.x += 1;
    }
    Block GetRandomBlock()
    {
        int rand = Random.Range(0 , GetAllprefabs.Length);
        return GetAllprefabs[rand];
    }
   List<Block>getAllBlocksChildren()
    {
        for (int i = 0 ; i < transform.childCount ; i++)
        {
            GetBlock.Add(transform.GetChild(i).GetComponent<Block>());
        }
        return GetBlock;
    }
}
