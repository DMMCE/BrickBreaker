using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerBackground : MonoBehaviour
{
    [SerializeField]
    Animator getBackgroundAnimator;
     
   public void ActiveDangerBackground(bool active)
    {
        getBackgroundAnimator.SetBool("danger" , active);
    }
}
