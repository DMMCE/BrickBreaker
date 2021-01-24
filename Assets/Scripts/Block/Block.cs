using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    [SerializeField]
    Animator GetAnimator;
    public int health;
    [SerializeField]
    GiftsManager GetGiftsManager;
   
    public SpriteRenderer GetSprite;
    private void Start()
    {
        GetGiftsManager = GameObject.FindGameObjectWithTag("GiftManager").GetComponent<GiftsManager>();
    }
    protected void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.transform.CompareTag("Ball"))
        {
         
            destroyBlock();
        }
    }
   
    public  virtual void destroyBlock()
    {

        GetSprite.sprite = null;
        GetGiftsManager.GenerateRandomGift(transform);
        BlocksBrokenCountManager.Instance.onDestroyBlock(1);
        Destroy(gameObject);
    }
    public virtual void LaserAttack()
    {

    }
    public virtual void BlockInDanger()
    {
        GetAnimator.SetBool("danger" , true);
    }


}
