using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallinBasket : MonoBehaviour
{
    private void Awake()
    {
        React();
    }
    float time = 2f;
    bool react = false;
    [SerializeField]
    Rigidbody2D GetRigidbody;
    void Update()
    {
        if (!react)
        {
            time -= Time.deltaTime;
            if (time <= 0f)
            {
                React();
            }
        }
    }
    void React()
    {
        GetRigidbody.AddForce(new Vector2(Random.Range(-8f , 8f) , Random.Range( 4f ,8f)) ,ForceMode2D.Force);
        time = Random.Range(2f,4f);
        react = false;
    }
    public void ActiveEffect(ParticleSystem particle)
    {
        particle.gameObject.transform.position = transform.position;
        particle.Play();

    }
}
