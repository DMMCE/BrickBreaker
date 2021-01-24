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
    List<Block> GetBlocks;

    int randomNumberofdestroyedBlocks;
    void Start()
    {
        InvokeRepeating("invoke_CheckUnbreakBlocks" , 1f , 1f);
        for (int i = 0 ; i < maximumNumberofBlockPerRow ; i++)
        {
            creatBlock();
        }
        randomNumberofdestroyedBlocks = Random.Range(0 , 10);
        GetBlocks = getAllBlocksChildren();

        for (int i = 0 ; i < GetBlocks.Count ; i++)
        {
            float rand = Random.value ;
            if(rand >= 0.4f && randomNumberofdestroyedBlocks > 0)
            {
 
                Destroy(GetBlocks[i].gameObject);
                GetBlocks.RemoveAt(i);
                randomNumberofdestroyedBlocks--;
            }
            else
            {

            }
        }
    }
    void invoke_CheckUnbreakBlocks()
    {
        if (allBlocksAreUnbreakable()) {
            Destroy(gameObject);
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
            GetBlocks.Add(transform.GetChild(i).GetComponent<Block>());
        }
        return GetBlocks;
    }
      
    public bool allBlocksAreUnbreakable()
    {
        bool AllmyBlocksAreUnbreakable = true;
        foreach (var item in GetBlocks)
        {
            if (item)
            {
                if (item.GetComponent<UnBreakerBlock>() == null)
                {
                    AllmyBlocksAreUnbreakable = false;
                }
            }
        }
        return AllmyBlocksAreUnbreakable;
    }
}
