using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowToAim : MonoBehaviour
{


	public bool Show;
	[SerializeField]
	GameObject Holder;

	public void ShowArrow(bool value)
	{
		Show = value;

	}
	private void Awake()
	{ 
		Show = true;   
 
	}   
	void Update()
	{
		if (Show)

		{
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);

		}
		Holder.SetActive(Show);

	}

	public Quaternion GetRotation()
	{
		return transform.rotation;

	}
}
