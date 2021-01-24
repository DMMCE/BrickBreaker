using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    public int NumberofBullet;
    public int NumberofGuns;



    [SerializeField]
    GameObject[] bulletFirstPosition;
    [SerializeField]
    Bullet GetBulletPrefab;
    [SerializeField]
    float reloadtime = 0.5f;
    bool reloading;
    private void Awake()
    {
        NumberofBullet = LocalDataManager.StartingBullets;
        NumberofGuns = LocalDataManager.startingGuns;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot_Bullet();
        }
        if (reloading)
        {
            reloadtime -= Time.deltaTime;
            if(reloadtime <= 0f)
            {
                reloading = false;
                reloadtime = 0.5f;
            }
        }
    }
    public void Shoot_Bullet()
    {
        if (NumberofBullet > 0 && reloading ==false)
        {
            for (int i = 0 ; i < NumberofGuns ; i++)
            {
                if (NumberofBullet > 0)
                {
                    Bullet currentbullet = GameObject.Instantiate(GetBulletPrefab , bulletFirstPosition[i].transform.position
                     , Quaternion.Euler(Vector3.zero) , transform);
                    currentbullet.ShootForward();
                    NumberofBullet--;
                }
                else
                {
                    NumberofBullet = 0;
                    break;
                }
            }
            reloading = true;
        }
    }

}
