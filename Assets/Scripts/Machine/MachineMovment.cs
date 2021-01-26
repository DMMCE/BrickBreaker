using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineMovment : MonoBehaviour
{
    [SerializeField] float X_Limit = 8.5f;
    [SerializeField] Collider2D GetCollider;
    private Vector3 screenPoint;
    private Vector3 offset;
    [SerializeField]
    MachineCollider GetMachineCollider;
    public bool canMove =false;

    private void Update()
    {
        if (!BallsInSceneManager.isThereAnyBallInScene()) { canMove = false; GetCollider.enabled = false; }
        else { GetCollider.enabled = true; canMove = true; }


        if (canMove)
        {
          RaycastHit2D raycastHit2D= Physics2D.Raycast(new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x ,
                Camera.main.ScreenToWorldPoint(Input.mousePosition).y) , Vector2.zero , 0f);
            if (raycastHit2D)
            if (raycastHit2D.collider.CompareTag("MachineCollider"))
            {
                screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.localPosition);

                offset = gameObject.transform.localPosition - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x , Input.mousePosition.y , screenPoint.z));

                    GetMachineCollider.Move(screenPoint,offset);
            }
        }
    }
    public void Set_XLimit(float value)
    {
        X_Limit = value;
    }
    public float Get_XLimit(   )
    {
      return  X_Limit  ;
    }


    
}
