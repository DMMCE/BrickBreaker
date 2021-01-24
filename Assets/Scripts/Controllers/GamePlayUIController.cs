using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayUIController : MonoBehaviour
{
    [SerializeField]
    Animator gameOver;
    [SerializeField]
    Animator pause;

    public void showGameOver(bool show)
    {
        gameOver.SetBool("popUp" , show);
    }
    public void showpause(bool show)
    {
        pause.SetBool("popUp" , show);
    }
}
