 
using UnityEngine;

public class UnBreakerBlock : Block
{
    public new void OnCollisionExit2D(Collision2D collision)
    {
        return;
    }
    public override void destroyBlock()
    {
      
        return;
    }

    public override void LaserAttack()
    {
        health--;
        if (health <= 0)
            Destroy(gameObject);
    }
    public override void BlockInDanger()
    {
       
    }

}
