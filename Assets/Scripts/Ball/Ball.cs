using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D GetRigidbody;
    [SerializeField]
    float Speed = 125f;
    
    public void Shoot(Transform directon)
    {
        GetRigidbody.AddForce(directon.up * Speed * Time.fixedDeltaTime,ForceMode2D.Force);
    }
    bool sameYaxis;
    float timeonSameYaxis = 2f;
    float y_value = 0f;
    private void LateUpdate()
    {
        if (transform.position.y == y_value)
        {
            sameYaxis = true;
        }
        else
        {
            sameYaxis = false;
            timeonSameYaxis = 2f;
        }
        if (sameYaxis)
        {
            timeonSameYaxis -= Time.deltaTime;
            if (timeonSameYaxis <= 0f)
            {
                GetRigidbody.AddForce(new Vector2 ( Speed* Time.fixedDeltaTime, Speed * Time.fixedDeltaTime));
                timeonSameYaxis = 2f;
            }

        }
    }
    private void FixedUpdate()
    {
        y_value = transform.position.y;
       
       

    }

}
