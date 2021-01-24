using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketManager : MonoBehaviour
{
    [SerializeField]
    ParticleSystem GetParticle; 
    [SerializeField]
    BallinBasket[] getBallinBaskets;

 

    public void NumberOfBallToShow(int length)

    {
       
        for (int i = 0 ; i < getBallinBaskets.Length ; i++)
        {
 
            if(i < length)
            getBallinBaskets[i].gameObject.SetActive(true);
            else if(length == i) {
              
                getBallinBaskets[i].ActiveEffect(GetParticle); 
                getBallinBaskets[i].gameObject.SetActive(false);
            }
            else getBallinBaskets[i].gameObject.SetActive(false);
        }
    }
}
