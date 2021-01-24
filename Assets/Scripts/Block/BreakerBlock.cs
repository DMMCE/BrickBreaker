 
using UnityEngine;

public class BreakerBlock : Block
{
    
    [SerializeField]
    Sprite  GetSpriteBreaker;
   
    public new void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.transform.CompareTag("Ball"))
        {
            health--;
           if(health < 2) { GetSprite.sprite = GetSpriteBreaker; }
            if (health <= 0)
            {
                destroyBlock();
            }
          
        }
    }
    public override void destroyBlock()
    {
        base.destroyBlock();
    }
    public override void LaserAttack()
    {
        health--;
        GetSprite.sprite = GetSpriteBreaker;
        if (health <= 0)
        {
            destroyBlock();
        }
    }
    
}
