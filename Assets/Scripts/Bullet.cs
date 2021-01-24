using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    float Speed;
    [SerializeField]
    Rigidbody2D GetRigidbody;
    [SerializeField]
    Collider2D GetCollider;
    [SerializeField]
    ParticleSystem hitEffect;
    public void ShootForward()
    {
        GetRigidbody.AddForce(new Vector2(0f , Speed * Time.deltaTime) , ForceMode2D.Force);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            Block hitblock = collision.gameObject.GetComponent<Block>();
            
            hitblock.destroyBlock();
            onbulletHit();


        }
    }
    void onbulletHit()
    {
        GetCollider.enabled = false;
        Destroy(transform.GetChild(0).gameObject);
        GetRigidbody.isKinematic = true;
        hitEffect.Play();
        Destroy(gameObject , hitEffect.time);
    }
}
