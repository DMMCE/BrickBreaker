using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineShooterManager : MonoBehaviour
{

    public int RemainBalls = 5;
    
    public Ball BallToShoot;
   
    public ArrowToAim ArrowToAim;
    List<Ball> GetBalls;

    Ball currentBall;
    [SerializeField]
    BasketManager GetBasketManager;

    bool ShootingWithArrow = true;
    private void Awake()
    {
        RemainBalls = LocalDataManager.StartingBalls;
        GetBasketManager.NumberOfBallToShow(RemainBalls);
        GetBalls = new List<Ball>();
    }
    bool gameOver=false;
    void Update()
    {
        if (!BallsInSceneManager.isThereAnyBallInScene())
        {
            ShootingWithArrow = true;
            ArrowToAim.ShowArrow(ShootingWithArrow);
            if(RemainBalls <= 0 && !gameOver)
            {
                gameOver = true;
                GameController.GameOver();
            }
        }
       
        
            if (Input.GetMouseButtonUp(0) && ShootingWithArrow && RemainBalls > 0)
            {
                currentBall = creatBall();
                RemainBalls--;
                currentBall.Shoot(ArrowToAim.transform);
                ShootingWithArrow = false;
                ArrowToAim.ShowArrow(ShootingWithArrow);
             GetBasketManager.NumberOfBallToShow(RemainBalls);
            }
       
        

    }
    Ball creatBall()
    {
        Ball newBall = GameObject.Instantiate(BallToShoot,
            ArrowToAim.transform.position, ArrowToAim.GetRotation(), transform);
        GetBalls.Add(newBall);
        return newBall;
    }
   
   

}


