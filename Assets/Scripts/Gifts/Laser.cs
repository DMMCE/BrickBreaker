using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : Gift
{
    [SerializeField]
    int LasershootMax = 2;
    [SerializeField]
    bool Vertical;
    [SerializeField]
    onballtriggerLaser GetOnballtrigger;
    [SerializeField] SpriteRenderer GetSprite;
    [SerializeField]
    Animator GetAnimation;

    private void Update()
    {
       
    }

    public new void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball") && LasershootMax > 0)
        {
            LasershootMax--;
            if (LasershootMax <= 0) destroygift();
            GetSprite.color = Color.red ;
            Active_Gift(collision);
            List<Block> newlist =    GetOnballtrigger.getallBlocks(Vertical);
            foreach (var item in newlist)
            {
                item.destroyBlock();
            }
            GetAnimation.SetBool("Play",false);
        }
    }
    public   void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            GetSprite.color = Color.white;
            if (LasershootMax == 1)
            {
                GetSprite.color = Color.blue;
               
            }
            GetAnimation.SetBool("Play" , true);
        }
    }
    public override void Active_Gift(Collider2D collision)
    {
        base.Active_Gift(collision);
    }
}
