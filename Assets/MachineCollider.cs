using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineCollider : MonoBehaviour
{
    [SerializeField]
    Transform ObjectToMove;
    private Vector3 screenPoint;
    private Vector3 offset;
    [SerializeField]
    MachineMovment GetMachineMovment;
    float X_Limit;
  
    public void Move (Vector3 screenpnt, Vector3 ofset) {


        screenPoint = screenpnt;
        offset = ofset;

    }
  
    void OnMouseDrag()
    {
        if (GetMachineMovment.canMove)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x , Input.mousePosition.y , screenPoint.z);

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            float x = Mathf.Clamp(curPosition.x , -GetMachineMovment.Get_XLimit() , GetMachineMovment.Get_XLimit());
            ObjectToMove.localPosition = new Vector3(x , 0f , 0f);
        }
    }
}
