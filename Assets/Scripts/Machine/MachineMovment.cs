using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineMovment : MonoBehaviour
{
    [SerializeField] float X_Limit = 8.5f;
    [SerializeField] Collider2D GetCollider;
    private Vector3 screenPoint;
    private Vector3 offset;

    bool canMove =false;
    private void Update()
    {
        if (!BallsInSceneManager.isThereAnyBallInScene()) { canMove = false; GetCollider.enabled = false; }
        else { GetCollider.enabled = true; canMove = true; }
    }
    public void Set_XLimit(float value)
    {
        X_Limit = value;
    }
    void OnMouseDown()
    {
        if (canMove)
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.localPosition);

            offset = gameObject.transform.localPosition - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x , Input.mousePosition.y , screenPoint.z));
        }
    }

    void OnMouseDrag()
    {
        if (canMove)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x , Input.mousePosition.y , screenPoint.z);

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            float x = Mathf.Clamp(curPosition.x , -X_Limit , X_Limit);
            transform.localPosition = new Vector3(x , 0f , 0f);
        }
    }
}
