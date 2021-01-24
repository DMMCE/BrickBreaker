using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineSizeGift : MonoBehaviour
{

    [SerializeField]
    int maxSizeLevel = 2;
    int level = 0;
    [SerializeField]
    MachineMovment GetXLimit;
    [SerializeField]
    Transform machineshape;
    [SerializeField]
    CapsuleCollider2D machineCollider;

    float timetoresize = 10f;
    private void Awake()
    {
        resetMachineSize();
    }
    private void Update()
    {
         timetoresize -= Time.deltaTime;
            if(timetoresize <= 0f)
            {
                timetoresize = 10f;
               
                addmachineSize(false);
            }
        
    }
    public void addmachineSize(bool add)
    {
        if (add)
        {
            level++;
            if (level >= maxSizeLevel)
            {
                level = maxSizeLevel;
            }
            timetoresize = 10f;
        }
        else
        {
            level--;
            if (level <=  0)
            {
                level = 0;
            }
        }

        InitializeMachineCollider(level);
    }
    void InitializeMachineCollider(int level)
    {
        switch (level)
        {
            case 0:
                {
                    machineshape.localScale = new Vector3(0.8f , 1f , 1f);
                    machineCollider.size = new Vector2(3f , 0.8f);
                    GetXLimit.Set_XLimit(7.84f);

                }
                break;

            case 1:
                {
                    machineshape.localScale = new Vector3(1f , 1f , 1f);
                    machineCollider.size = new Vector2(4f , 0.9f);
                    GetXLimit.Set_XLimit(7.5f);
                    break;
                }
            case 2:
                {
                    machineshape.localScale = new Vector3(1.1f , 1f , 1f);
                    machineCollider.size = new Vector2(4.5f , 0.9f);
                    GetXLimit.Set_XLimit(7.3f);
                    break;
                }
            default:
                break;
        }
      
    }

    public void resetMachineSize()
    {
        InitializeMachineCollider(0);
    }
}
