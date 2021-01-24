using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftsManager : MonoBehaviour
{
    public Gift[] GetAllTypeofGifts;

    public List<Gift>  GetCurrentGifts;
    [SerializeField]
    Transform frozengiftsholder;
    private void Start()
    {
        GetCurrentGifts = new List<Gift>();
    }
    bool destroyedAllGifts = false;
    void destroyAllGifts()
    {
        foreach (var giftinScene in GetCurrentGifts)
        {
            if(giftinScene != null)
            giftinScene.destroygift();
           
        }
    }
    private void Update()
    {
        if (!BallsInSceneManager.isThereAnyBallInScene() && destroyedAllGifts)
        {
            destroyAllGifts();
        }
        else { destroyedAllGifts = true; }
    }
    public  void GenerateRandomGift(Transform position)
    {
       blockgifts.BlockGifts newtype =  blockgifts.Get_RandomGift();
        for (int i = 0 ; i < GetAllTypeofGifts.Length ; i++)
        {
            if(newtype == GetAllTypeofGifts[i].GetBlockgifts)
            {
                if(newtype == blockgifts.BlockGifts.horizantallazer 
                    || newtype == blockgifts.BlockGifts.verticallaser)
                {
                    GetCurrentGifts.Add(GameObject.Instantiate(GetAllTypeofGifts[i] ,
               position.position , Quaternion.Euler(Vector3.zero) , frozengiftsholder));
                }
                else if (newtype == blockgifts.BlockGifts.none)
                {
                    return;
                }
                else
                {
                    GetCurrentGifts.Add(GameObject.Instantiate(GetAllTypeofGifts[i] ,
                 position.position , Quaternion.Euler(Vector3.zero) , transform));
                }
             
            }
        }
    }
    public void translateUnfroozengifts()
    {
        frozengiftsholder.position = 
            new Vector3(frozengiftsholder.position.x , frozengiftsholder.position.y - 1f , frozengiftsholder.position.z);

    }

}
