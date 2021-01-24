using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsInSceneManager : MonoBehaviour
{
    public static bool isThereAnyBallInScene()
    {
        if (GameObject.FindGameObjectsWithTag("Ball").Length == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
